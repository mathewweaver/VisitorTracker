
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Imports Newtonsoft
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters

Public NotInheritable Class DateTimeHelper

  ''' <summary>
  ''' Converts the given DateTime to a long (Int64) value that represents the corresponding Javascript timestamp (number of milliseconds since 01-Jan-1970 00:00:00 UTC).
  ''' </summary>
  ''' <param name="input">The DateTime that will be converted to a Javascript timespace.</param>
  ''' <returns>The long (Int64) value that represents the DateTime input as the number of milliseconds elapsed since 01-Jan-1970 00:00:00 UTC.</returns>
  Public Shared Function ToJavascriptTimestamp(input As System.DateTime) As Long
    ' adapted from a code excerpt found at http://people.iola.dk/olau/flot/API.txt
    Dim epoch = New DateTime(1970, 1, 1, 0, 0, 0, input.Kind)
    Dim time = input.Subtract(epoch)
    Return CLng(time.Ticks / 10000)
  End Function

  ''' <summary>
  ''' Converts the given Javascript timestamp (aka long value representing the number of milliseconds since 01-Jan-1970 00:00:00 UTC) into the corresponding DateTime value.
  ''' </summary>
  ''' <param name="timestamp">The Javascript timestamp (aka long value representing the number of milliseconds elapsed since 01-Jan-1970 00:00:00 UTC).</param>
  ''' <returns>The DateTime value represented by the given timestamp.</returns>
  Public Shared Function FromJavascriptTimestamp(timestamp As Long) As DateTime
    Dim epoch = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
    Return epoch.AddTicks(timestamp * 10000)
  End Function

End Class

''' <summary>
''' Adapted from http://cgeers.com/2011/09/25/writing-a-custom-json-net-datetime-converter/
''' </summary>
Public Class JavaScriptTimestampDateTimeConverter
  Inherits DateTimeConverterBase

  Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object
    If reader.TokenType <> JsonToken.[Integer] Then
      Throw New Exception([String].Format("Unexpected token parsing date. Expected Integer, got {0}.", reader.TokenType))
    End If

    Dim timestamp = CLng(reader.Value)

    Return DateTimeHelper.FromJavascriptTimestamp(timestamp)
  End Function

  Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
    Dim timestamp As Long
    If TypeOf value Is DateTime Then
      timestamp = DateTimeHelper.ToJavascriptTimestamp(DirectCast(value, DateTime))
    Else
      Throw New Exception("Expected date object value.")
    End If
    writer.WriteValue(timestamp)
  End Sub

End Class

