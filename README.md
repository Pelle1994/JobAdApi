# JobAdApi
ASP.NET Core Web Api using Entity Framework Core

Small web api for fetching restaurant job ads from Arbetsförmedlingen API and saving them in a SQL/SQLite Db

The controller uses a GET request to fetch job ads with 

"occupation_field": {
    "concept_id": "ScKy_FHB_7wT",
    "label": "Hotell, restaurang, storhushåll"
    }
    
that has been added during the past month. The response gets mapped to a specific model that will be saved in a database. Every call will delete all rows in the db and insert new ones.
    
For this API, you will need to register to get your own API key at apirequest.jobtechdev.se

Put your API key in appsettings.json object "Api-Key".

In startup.cs you can choose SQL or SQLite Db. Uncomment the commented lines in ApiService.cs if you change db in startup.cs.
