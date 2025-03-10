# Working With Barcode

## Описание

Этот проект представляет собой пример работы с штрих-кодами и QR-кодами на C# 7.0. Он демонстрирует, как можно генерировать, сканировать и обрабатывать различные типы штрих-кодов и QR-кодов.

## Основные функции

- **Генерация штрих-кодов и QR-кодов**: Создание штрих-кодов и QR-кодов на основе введенных данных.
- **Сканирование штрих-кодов и QR-кодов**: Использование камеры для сканирования и распознавания штрих-кодов и QR-кодов.
- **Обработка данных**: Обработка и анализ данных, полученных из штрих-кодов и QR-кодов.

## Установка и запуск

### Требования

- .NET Framework 4.7.2 или выше
- Visual Studio 2019 или выше
- Git

### Установка

1. **Клонируйте репозиторий:**

    ```sh
    git clone https://github.com/DKAVrZoV65F/working-with-barcode.git
    cd WorkingWithBarcode
    ```

2. **Откройте проект в Visual Studio:**

    Откройте решение `WorkingWithBarcode.sln` в Visual Studio.

3. **Установите зависимости:**

    Visual Studio автоматически установит все необходимые зависимости.

### Запуск

1. **Запуск приложения:**

    Выберите целевую платформу (Windows) и нажмите кнопку "Запуск" в Visual Studio.

## Примеры использования

### Пример 1: Генерация QR-кода

```csharp
// Пример кода на C# для генерации QR-кода
using QRCoder;

var qrGenerator = new QRCodeGenerator();
var qrCode = qrGenerator.CreateQrCode("Hello, World!", QRCodeGenerator.ECCLevel.Q);
var qrCodeImage = new PngByteQRCode(qrCode);
var qrCodeAsPng = qrCodeImage.GetGraphic(20);

using (var stream = new FileStream("qr_code.png", FileMode.Create))
{
    qrCodeAsPng.Save(stream);
}
```

### Пример 2: Сканирование штрих-кода

```csharp
// Пример кода на C# для сканирования штрих-кода
using ZXing;

var barcodeReader = new BarcodeReader();
var result = barcodeReader.Decode("path_to_barcode_image.png");

if (result != null)
{
    Console.WriteLine($"Scanned barcode: {result.Text}");
}
```
