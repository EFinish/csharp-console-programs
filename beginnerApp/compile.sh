if [ -e "main.exe" ]
then
    rm main.exe
fi
mcs main.cs AppConfig.cs Action.cs
if [ -e "main.exe" ]
then
    mono main.exe
else 
    echo "Execution file not generated\n"
fi
