# Autosar arxml general serializer and deserializer
    Autosar arxml general serializer and deserializer is base on LinqToXsdCore.
    Autosar is complaint with Autosar V4.4 and AUTOSAR_00046.xsd.

    The code is generated through the following procedure,
    1. LinqToXsdCore is published as a global .NET tool here: https://www.nuget.org/packages/LinqToXsdCore
    2. Install LinqToXsdCore 
    dotnet tool install LinqToXsdCore -g
    3. Create config file 
    linqtoxsd config -e AUTOSAR_00046.xsd
    4. Generate code 
    linqtoxsd gen AUTOSAR_00046.xsd -c .\AUTOSAR_00046.xsd.config

    Usage can be found in project Autosar-Configurator https://github.com/DD-Silence/Autosar-Configurator

    Feel free to try the function and feedback by issues.
