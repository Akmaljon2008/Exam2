﻿Управление задачами в проекте

Вы разрабатываете систему управления задачами для проекта. У вас есть база данных с таблицами, содержащими информацию о задачах, проектах и сотрудниках.

Таблицы в вашей базе данных:

Tasks:
- TaskID
- ProjectID
- Title
- Description
- AssignedTo
- DueDate
- Status

Projects:
- ProjectID
- Name
- Description
- StartDate
- EndDate

Employees:
- EmployeeID
- Name
- Department

Напишите запросы для следующих действий:

1. Получение списка всех задач, назначенных определенному сотруднику (например, сотруднику с идентификатором 1), включая заголовки, описания, сроки выполнения и статусы задач.
2. Получение списка всех проектов вместе с общим количеством задач в каждом проекте и количеством завершенных задач.
3. Получение списка всех сотрудников, участвующих в конкретном проекте (например, проект с идентификатором 1), включая их идентификаторы, имена и отделы.
4. Получение списка всех задач в определенном проекте (например, проект с идентификатором 1), включая заголовки, описания, сроки выполнения и статусы задач.
5. Напишите методы CRUD для этих таблиц.