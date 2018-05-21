## Sample Windows console wrapper in C#

This is a quick sample for executing a process and grabbing its output stream.

Useful if you're wanting to grab the console output of simple commands, or other applications.


### Example
```
INPUT:
ping xenoinc.com


OUTPUTS:
Pinging xenoinc.com [111.222.333.444] with 32 bytes of data:
Reply from 111.222.333.444: bytes=32 time=62ms TTL=52
Reply from 111.222.333.444: bytes=32 time=62ms TTL=52
Reply from 111.222.333.444: bytes=32 time=62ms TTL=52
Reply from 111.222.333.444: bytes=32 time=65ms TTL=52

Ping statistics for 111.222.333.444:
    Packets: Sent = 4, Received = 4, Lost = 0 (0% loss),
Approximate round trip times in milli-seconds:
    Minimum = 62ms, Maximum = 65ms, Average = 62ms
```