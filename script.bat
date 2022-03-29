echo off
set branch="master"

git clone "https://github.com/LaOctoProduction/TestIndustrialisation"
git pull "hhttps://github.com/LaOctoProduction/TestIndustrialisation" %branch% 

cd TestIndustrialisation

dotnet restore
dotnet build>build.txt

for /F "UseBackQ Delims==" %%A in ("build.txt") do set "lastlineBuild=%%A"
for /F "tokens=1" %%a in ("%lastlineBuild%") do set resultBuild=%%a 
if not "%resultBuild%" == "RestaurantTest " EXIT /B

dotnet test>tests.txt

for /F "UseBackQ Delims==" %%A in ("tests.txt") do set "lastlineTest=%%A"
for /F "tokens=1" %%a in ("%lastlineTest%") do set resultTest=%%a
chcp 65001
if not "%resultTest%" == "Réussi! " EXIT /B

pause