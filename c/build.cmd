@echo off
call "%VS100COMNTOOLS%vsvars32.bat"
echo f | xcopy /Y jansson\src\jansson_config.h.win32 jansson\src\jansson_config.h
type jansson.msvc-fix >> jansson\src\jansson_config.h

if not exist obj mkdir obj
cl *.c jansson\src\*.c /I jansson\src /Foobj\
