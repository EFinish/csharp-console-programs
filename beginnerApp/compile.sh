if [ -e "main.exe" ]
then
    rm main.exe
fi
mcs main.cs
mono main.exe
