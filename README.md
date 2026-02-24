### Simple API Pray Time Example

This project is a simple C# console application that retrieves Islamic prayer times for Sfax, Tunisia using the Aladhan API. It fetches the daily prayer timings, along with the Gregorian date, Hijri month, and timezone information. The output is displayed in a formatted console interface using Spectre.Console.

The application works by sending a GET request to the Aladhan API using the current date. The API returns a JSON response containing the daily prayer times and date information. The program parses this response using Newtonsoft.Json and prints the results in an organized format. The link used for fetching the data follows the pattern:
https://api.aladhan.com/v1/timingsByAddress/DD-MM-YYYY?address=Sfax,Tunisia

This project is built using C#, .NET, HttpClient for making API requests, Newtonsoft.Json for JSON parsing, and Spectre.Console for styling the console output. It demonstrates how to perform simple API calls, parse JSON data, and display formatted results in a console application.

To use this project, clone the repository and restore the required NuGet packages, which are Newtonsoft.Json and Spectre.Console. After running the program, the console will display the current day's prayer times along with the related date and timezone information.

For more details about the API, you can refer to the official Aladhan API documentation at:
https://aladhan.com/prayer-times-api

This project is open-source and distributed under the MIT License.
