Remaining Todos:
- Remove any unnecessary code, including some unneeded console statements
- Console should not be anywhere inside the Lib project. 
    - Replace useful console statements with a generic printer inferface using Dependency injection
    - Interface: IPrinter {...} with one void method called 'Print(string message);'
- Replace PrintDetails with a string method called 'ToString()' 
- Replace the ListAllPets and ListAllAdoptions with GetAllPets and GetAllAdoptions
- Add in a test project with a couple simple tests
    - dotnet new xunit -o PetShelterTests
    - dotnet sln add ./PetShelterTests/PetShelterTests.csproj
    - dotnet add ./PetShelterTests/PetShelterTests.csproj reference ./PetShelterLib/PetShelterLib.csproj
    - dotnet add ./PetShelterTests/PetShelterTests.csproj reference ./PetShelterList/PetShelterList.csproj
- 2 Major issues to be addressed, related to reference types. (Hint: Inside the Storage classes) 
- Introduce debugging in VS Code