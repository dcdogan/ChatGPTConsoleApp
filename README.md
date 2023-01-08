# ChatGPT Console App

This .NET console application allows users to interact with ChatGPT, a language model developed by OpenAI, through a command line interface.

## Prerequisites

- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) or later
- An API key for the [OpenAI API](https://beta.openai.com/)

## Getting Started

1. Clone this repository to your local machine:

git clone https://github.com/dcdogan/ChatGPTConsoleApp.git

2. Navigate to the directory where the repository was cloned:

cd chatgpt-console-app

3. Set the `OPENAI_API_KEY` environment variable to your OpenAI API key:

set OPENAI_API_KEY=<your-api-key>

4. Run the console app:

dotnet run

5. Enter a prompt and ChatGPT will generate a response based on the provided input.

## Usage

To use the app, simply enter a prompt and press Enter. ChatGPT will generate a response and display it in the console. To exit the app, enter `exit` or press Ctrl+C.

## Limitations

The ChatGPT Console App is intended for experimentation and testing purposes only. It is limited by the capabilities of the ChatGPT model and the usage limits of the OpenAI API.

## Credits

This app was developed using the [OpenAI API](https://beta.openai.com/) and the [.NET Core](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) framework.
