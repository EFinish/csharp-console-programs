if [ -e "main.exe" ]
then
    rm main.exe
fi
mcs main.cs AppConfig.cs cyoaTools/PlayerAction.cs cyoaTools/PlayerState.cs
if [ -e "main.exe" ]
then
    mono main.exe
else 
    echo "Execution file not generated\n"
fi
