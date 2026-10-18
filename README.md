# billiard-training
Система планирования тренировок и отслеживания прогресса в русском бильярде

## Текущее состояние

Минимальное ASP.NET Core приложение на .NET 10. Маршрут `GET /` возвращает название API в JSON. База данных и логика тренировок пока не добавлены.

## Требования

- .NET SDK 10.0.
- Rider для запуска из IDE либо терминал для запуска командами ниже.

Проверка установленного SDK:

```powershell
dotnet --info
```

## Запуск в Rider

1. Через **File → Open** откройте файл `BilliardTraining.slnx` как решение.
2. Дождитесь загрузки проекта `BilliardTraining.Api`.
3. Выберите конфигурацию запуска проекта с профилем `http` из `Properties/launchSettings.json` и нажмите **Run**.
4. Дождитесь строки `Now listening on: http://localhost:5080` в журнале запуска.
5. Откройте `http://localhost:5080/` в браузере либо выполните запрос из `src/BilliardTraining.Api/BilliardTraining.Api.http` кнопкой рядом с `GET`.

Для просмотра корневых файлов переключите левую панель Explorer в **File System**. Остановить приложение можно кнопкой **Stop**.

## Запуск из терминала

Выполняйте команды из корневой папки репозитория:

```powershell
dotnet build BilliardTraining.slnx
dotnet run --project src/BilliardTraining.Api --launch-profile http
```

`build` собирает решение. `run` собирает и запускает приложение; `--project` задаёт его каталог, `--launch-profile http` выбирает локальный профиль запуска.

Пока приложение работает, терминал занят им. Для остановки нажмите **Ctrl+C**.

## Проверка ответа

Запрос `GET http://localhost:5080/` должен вернуть статус `200 OK` и JSON:

```json
{"name":"Billiard Training API"}
```

Файл `.http` отправляет запрос к уже запущенному приложению. Он не запускает сервер.

При `Connection refused` сначала проверьте, что приложение запущено и в журнале указан нужный адрес и порт. Если запуск завершился ошибкой, начните с её текста в журнале. При ошибке о занятом порте проверьте, не запущена ли другая копия приложения.

## Структура

- `BilliardTraining.slnx` — решение со списком проектов.
- `src/BilliardTraining.Api/BilliardTraining.Api.csproj` — настройки веб-проекта.
- `src/BilliardTraining.Api/Program.cs` — создание приложения и регистрация маршрута.
- `src/BilliardTraining.Api/Properties/launchSettings.json` — локальный профиль запуска: HTTP, порт 5080, окружение Development.
- `src/BilliardTraining.Api/BilliardTraining.Api.http` — запрос для проверки API.

## Документация

- [Запуск с launchSettings.json в Rider](https://www.jetbrains.com/help/rider/Running_LaunchSettings.html).
- [Просмотр файлов в Rider](https://www.jetbrains.com/help/rider/Project_Tool_Window.html).
- [Команда dotnet run](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-run).
