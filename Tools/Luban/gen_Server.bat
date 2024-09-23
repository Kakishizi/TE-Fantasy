set WORKSPACE=.
set LUBAN_DLL=%WORKSPACE%\Core\Luban.dll
set CONF_ROOT=.

dotnet %LUBAN_DLL% ^
    -t server ^
    -c cs-bin ^
    -d bin ^
    --conf %CONF_ROOT%\luban.conf ^
    -x outputDataDir=..\..\Config\Binary\Luban^
    -x outputCodeDir=..\..\Server\Model\Generate\Luban\Code

pause