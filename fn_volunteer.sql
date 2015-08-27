
alter FUNCTION fn_volunteer 
(
   @vo_id int
	,@dt datetime2(7) = null
)
RETURNS 
@vi TABLE 
(
	 start_dt datetime
  ,end_dt datetime
  ,hrs real 
)
AS
BEGIN
	
  -- get earliest date
  if @dt is null
    set @dt = (select max(c.dt) 
                 from dbo.st_calendar c 
                where c.dt < (select min(vt.start_dt) 
                                from dbo.dt_volunteer_time vt
                               where vt.vo_id = @vo_id));

  -- compute hourly segments
  insert @vi ( start_dt, end_dt )
  select dateadd(hour,n.N, c.dt)
        ,dateadd(ms,-10,dateadd(hour,n.N+1, cast(c.dt as datetime2)))
    from dbo.st_calendar c, st_number n
   where c.dt >= @dt
     and c.dt <= dateadd(day,0,getdate())
     and n.N <= 23;

	
  -- compute count
  update @vi set
      hrs = coalesce((select sum(datediff(minute,vt.start_dt,vt.stop_dt)) from dbo.dt_volunteer_time vt where vt.vo_id = @vo_id and vt.start_dt between i.start_dt and i.end_dt),0) / 60.0
    from @vi i;

	RETURN 
END
GO