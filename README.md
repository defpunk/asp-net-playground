A play ground for experimenting with older .NET features to help understand a legacy system

You may need to run these commands if when you run IIS you get ssl errors

dotnet dev-certs https --clean
dotnet dev-certs https
dotnet dev-certs https --trust