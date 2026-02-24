Simple API Pray Time Example

This is a simple C# console application that fetches Islamic prayer times for Sfax, Tunisia using the Aladhan API.
The program retrieves daily prayer timings, date information in both Gregorian and Hijri formats, and displays them in a formatted console output using Spectre.Console.

Features

Fetches prayer times from the Aladhan API.

Displays:

Gregorian date

Hijri month

Timezone

Fajr, Dhuhr, Asr, Maghrib, and Isha times

Styled console output using Spectre.Console.

Technologies Used

C#

.NET

HttpClient

Newtonsoft.Json (JSON parsing)

Spectre.Console (console styling)

Aladhan API

How It Works

The application sends a GET request to the API endpoint:

https://api.aladhan.com/v1/timingsByAddress/DD-MM-YYYY?address=Sfax,Tunisia

It then extracts and displays the prayer time information from the JSON response.

Usage

Clone the repository.

Restore required NuGet packages:

Newtonsoft.Json

Spectre.Console

Run the project.

You should see the daily prayer times displayed in your console.

API Reference

Aladhan API Documentation:
https://aladhan.com/prayer-times-api

License

This project is open-source and available under the MIT License.
