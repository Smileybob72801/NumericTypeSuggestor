# NumericTypeSuggestor

**NumericTypeSuggestor** is a simple WinForms application that helps developers determine the best numeric data type to use based on the range of values they expect in their application.

## Features

- 🔢 **Range Evaluation:** Input a minimum and maximum value, and the app will suggest the most appropriate numeric type (e.g., `int`, `long`, `decimal`, etc.).
- 🧮 **Integral and Floating-Point Support:** Choose whether to include floating-point types or limit suggestions to integral types only.
- ✅ **Precision Control:** Option to restrict suggestions to types that maintain exact precision (e.g., `decimal`).
- 🎨 **Dynamic Validation:** Real-time input validation and suggestions as you type.

## Screenshots

[![Numeric Type Suggestor]
(https://raw.githubusercontent.com/Smileybob72801/NumericTypeSuggestor/master/screenshots/numericTypeSuggesterScreenshot.png)]
(https://raw.githubusercontent.com/Smileybob72801/NumericTypeSuggestor/master/screenshots/numericTypeSuggesterScreenshot.png)

## Instructions

1. Download and extract the latest release.
2. Run `NumericTypeSuggestor.exe`.
3. Input the minimum and maximum values in the respective fields.
4. Select the desired options for precision and type restrictions.
5. View the suggested numeric type displayed in the app.

## Build the Project

Clone the repository:
```bash
git clone https://github.com/YourUsername/NumericTypeSuggestor.git
```

Navigate to the project directory:
```bash
cd NumericTypeSuggestor/NumericTypeSuggestor
```

Build the project:
```bash
dotnet build
```

Run the application:
```bash
dotnet run
```

## Technologies Used

- **WinForms** for creating the desktop application interface.
- **.NET Core** for backend logic and calculations.


## Prerequisites

- **Windows OS**

- **.NET SDK 8.0** or later

## Future Enhancements

🌐 Cross-Platform Support: Plan to expand the application for cross-platform use with .NET MAUI.

📊 Visual Range Indicators: Add graphical representations of ranges for better visual feedback.
