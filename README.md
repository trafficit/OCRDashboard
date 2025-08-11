# OCRDashboard
OCRDashboard** is a C#/.NET-based application for extracting text from images and scanned documents using Optical Character Recognition (OCR). It is designed to process files such as `Shilder1`, which may contain printed or handwritten text

## Features

- Upload and process image files (`.jpg`, `.png`, `.tiff`, `.pdf`)
- Text recognition using Tesseract OCR via .NET bindings
- Multi-language OCR support
- Preview original image and extracted text
- Edit and export results (`.txt`, `.csv`, `.json`)
- History of processed files

- ## Example: Processing `Shilder1`

The file `Shilder1` serves as a sample input for OCRDashboard. The application allows users to:

1. Upload `Shilder1` via the dashboard
2. Automatically detect and extract text using OCR
3. Review and edit the output
4. Export the result for further use

---

## Technologies

| Component   | Stack                     |
|------------|---------------------------|
| Language    | C#                        |
| Framework   | .NET 8 / ASP.NET Core     |
| OCR Engine  | Tesseract OCR (.NET wrapper) |
| Frontend    | Blazor / Razor Pages      |
| Storage     | SQLite / Entity Framework |
| CI/CD       | GitHub Actions / Azure Pipelines |

---

## Installation

Clone the repository:

```bash
git clone https://github.com/Oleksander/OCRDashboard.git
cd OCRDashboard
Build and Run
bash
dotnet restore
dotnet build
dotnet run
API Usage
Endpoint:

http
POST /api/ocr
Content-Type: multipart/form-data
Request:

Upload a file such as Shilder1.png

Response:

json
{
  "filename": "Shilder1.png",
  "text": "Extracted text content",
  "language": "eng",
  "confidence": 89.3
}
