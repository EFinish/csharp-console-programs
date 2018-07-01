if [ -e "main.exe" ]
then
    rm main.exe
fi
csc main.cs AppConfig.cs Action.cs
if [ -e "main.exe" ]
then
    main.exe
else 
    echo "Execution file not generated\n"
fi
