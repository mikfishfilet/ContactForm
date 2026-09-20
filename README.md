# ContactApp

## Description

ContactApp is a Razor Pages web application built with ASP.NET Core. It provides a contact form that allows users to enter their name, email address, and message.

The application validates the submitted information and saves valid contact submissions to a JSON file.

## Features

* Contact form built with Razor Pages
* Name, email, and message fields
* Required field validation
* Email address validation
* Message length validation
* Saves submitted contacts to `data/contacts.json`
* Displays a thank-you page after a successful submission
* Navigation bar with Home, Contact, and Privacy pages

## Contact Model

The `Contact` model contains:

* `Name` — required
* `Email` — required and must be a valid email address
* `Message` — required and limited to 200 characters

## How It Works

1. The user navigates to the Contact page.
2. The user enters their name, email, and message.
3. The form validates the submitted information.
4. Valid submissions are saved to `data/contacts.json`.
5. The user is redirected to the Thank You page.

## Technologies Used

* C#
* ASP.NET Core
* Razor Pages
* HTML
* CSS
* JSON
* .NET 10

## Project Structure

```text
ContactApp/
├── Models/
│   └── Contact.cs
├── Pages/
│   ├── Contact.cshtml
│   ├── Contact.cshtml.cs
│   ├── ThankYou.cshtml
│   └── Shared/
├── data/
│   └── contacts.json
├── wwwroot/
│   └── css/
│       └── site.css
├── Program.cs
└── ContactApp.csproj
## Screenshots
<img width="290" height="306" alt="image" src="https://github.com/user-attachments/assets/0d93540d-a3c7-4900-9907-aad0b7e5da59" />

<img width="249" height="269" alt="image" src="https://github.com/user-attachments/assets/959840c6-8a0a-4b62-b501-93ab89bb6782" />
