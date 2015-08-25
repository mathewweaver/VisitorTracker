
alter FUNCTION fn_visitor 
(
	@dt datetime2(7) = null
)
RETURNS 
@vi TABLE 
(
	 start_dt datetime
  ,end_dt datetime
  ,cnt int 
)
AS
BEGIN
	
  -- get earliest date
  if @dt is null
    set @dt = (select max(c.dt) 
                 from dbo.st_calendar c 
                where c.dt < (select min(v.dt) 
                                from dbo.dt_visitor v));

  -- compute hourly segments
  insert @vi ( start_dt, end_dt )
  select dateadd(hour,n.N, c.dt)
        ,dateadd(ms,-10,dateadd(hour,n.N+1, cast(c.dt as datetime2)))
    from dbo.st_calendar c, st_number n
   where c.dt > @dt
     and c.dt < dateadd(day,0,getdate())
     and n.N <= 23;

	
  -- compute count
  update @vi set
      cnt = (select count(*) from dbo.dt_visitor v where v.dt between i.start_dt and i.end_dt)
    from @vi i;

	RETURN 
END
GO