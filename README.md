# File-converter

A software made with C# (.NET framework 4.8) Winforms that coverts between diffrent file formats (image, text, video...)

As a winforms application, this only runs on **Windows** 
# Text files

Implemented file formats:
- Text file (*.txt)
- Pdf files (*.pdf)
- Word files (*.docx) (_requires ms word installed on machine_)

Table of possible conversions

|  From / To | .txt | .pdf | .docx |
| ------------- | ------------- | ------------- | ------------- |
| .txt  | N/A |  YES | YES  |
| .pdf  | YES | N/A |  LIMITED |
| .docx | YES | YES | N/A  |


# Image files

Implemented file formats:
- PNG file (*.png)
- JPG files (*.jpg)
- ICO files (*.ico) 
- WEBP files (*.webp) (_not yet implemented_)
- GIF files (*.gif)
- TIFF files (*.tiff)
- BMP files (*.bmp)

Table of possible conversions

|  From / To | .png | .jpg | .ico | .webp| .gif | .tiff| .bmp |
| ---------- | ---- | ---- | ---- | ---- | ---- | ---- | ---- |
| .png       | N/A  | YES  | YES  | NO   | YES  | YES  | YES  |
| .jpg       | YES  | N/A  | YES  | NO   | YES  | YES  | YES  |
| .ico       | YES  | YES  | N/A  | NO   | YES  | YES  | YES  |
| .webp      | YES  | YES  | YES  | N/A  | YES  | YES  | YES  |
| .gif       | YES  | YES  | YES  | NO   | N/A  | YES  | YES  |
| .tiff      | YES  | YES  | YES  | NO   | YES  | N/A  | YES  |
| .bmp       | YES  | YES  | YES  | NO   | YES  | YES  | N/A  |

# Packages used
- [IText7](https://github.com/itext/itext7-dotnet) for creating and updating PDF documents.
- **TRIAL** version of [Pdf Focus](https://www.sautinsoft.com/products/pdf-focus/order.php) for converting PDF files to Word documents. _(Since its a trial version limitation apply to resulting word files converted from pdf files)_
- [Material skin for winforms](https://github.com/leocb/MaterialSkin) for the UI.

# Some Images
Maybe layer <-:
