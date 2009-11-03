Name "Simple.Net project"
OutFile "Simple.exe"
Icon "..\doc\SimpleIcon.ico"
RequestExecutionLevel user
AutoCloseWindow true
BrandingText "juanplopes@gmail.com"

;Default installation folder
InstallDir "$EXEDIR"

Page directory
Page instfiles

Section
  File lib\Simple.dll
  File /r /x _svn /x bin /x obj /x *.nsi /x Simple.exe /x lib\Simple.dll *.* 
  ExecWait $OUTDIR\SimpleGui.exe
  Delete $OUTDIR\SimpleGui.exe
SectionEnd