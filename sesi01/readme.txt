manual compiler
- open in integrated terminal
- type in terminal 'mcs hello.cs' (output file compile .exe)
- type in terminal 'mcs hello.cs -out:hello' (hello.cs = nama file , hello = nama file output yang diinginkan)

run dengan mono:
- type in terminal 'mono hello' (hello = nama hasil file compile)

Menggunakan output compile hasil mono dengan tujuan agar dapat dipakai seluruh platform karena .exe hanya dapat digunakan di window


automatic compiler
Create dan Compile
- type in terminal 'dotnet new console'
- type in terminal 'dotnet run'(compile dilakukan secara otomatis bersamaan dengan run)