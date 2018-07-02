call "%VS140COMNTOOLS%../../VC/vcvarsall.bat" x86
LIB /DEF:sqlite3.def
cl program.c /link sqlite3.lib
echo "setup completed"