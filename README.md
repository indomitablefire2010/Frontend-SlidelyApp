
# SlidelyFormApp Front  End

Welcome to the front  end component of SlidelyFormApp! This application is designed to help you manage and view submissions with ease. Whether you're navigating through entries or deleting old ones, this app provides a straightforward interface for all your needs.

## Table of Contents

   [Features](#features)
   [Technologies](#technologies)
   [Installation](#installation)
   [Usage](#usage)
   [Key Bindings](#key  bindings)
   [Contribution](#contribution)
   [License](#license)

## Features

This project comes with a variety of features to help you manage submissions efficiently:

   Fetch Submissions: Automatically retrieve submissions from our backend API.
   Navigate Submissions: Use 'Next' and 'Previous' buttons to browse through submissions.
   Delete Submissions: Easily delete unwanted submissions with confirmation prompts to avoid accidental deletions.

## Technologies

Here are the technologies that power this project:

   .NET Framework
   Windows Forms
   Visual Basic .NET (VB.NET)
   Newtonsoft.Json for JSON handling
   HttpClient for making HTTP requests

## Installation

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

   .NET Framework
   Visual Studio

### Steps

1. Clone the Repository:
   Start by cloning the repository to your local machine:
     sh
   git clone https://github.com/yourusername/SlidelyFormApp.git
     

2. Open in Visual Studio:
   Navigate to the project directory and open it with Visual Studio:
     sh
   cd SlidelyFormApp/SlidelyFormApp  Frontend
     

3. Restore NuGet Packages:
   Restore the necessary packages:
     sh
   nuget restore
     

4. Build the Project:
   Build the project to ensure everything is set up correctly:
     sh
   Ctrl + Shift + B
     

## Usage

Once everything is set up, here's how you can start using the application:

1. Run the Application:
   Launch the application directly from Visual Studio.

2. View Submissions:
   The main form will display submissions fetched from the backend. You'll see details like name, email, phone number, GitHub link, and stopwatch time.

3. Navigate Through Submissions:
   Use the 'Next' and 'Previous' buttons to move through the submissions.

4. Delete Submissions:
   To delete a submission, simply click the 'Delete' button and confirm your action when prompted.

## Key Bindings

To make navigation  easier, you can use these keyboard shortcuts:

   Ctrl + N: Go to the next submission.
   Ctrl + P: Go to the previous submission.
   Ctrl + D: Delete the current submission.

###  API Endpoints

   Fetch Submissions: `http://localhost:3000/submissions`
   Delete Submission: `http://localhost:3000/delete?index={currentIndex}`
