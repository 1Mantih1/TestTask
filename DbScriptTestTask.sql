-- Таблицы
CREATE TABLE [dbo].[status](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [varchar](100) NOT NULL,
CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[posts](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [varchar](100) NOT NULL,
CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[deps](
[id] [int] IDENTITY(1,1) NOT NULL,
[name] [varchar](100) NOT NULL,
CONSTRAINT [PK_deps] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[persons](
[id] [int] IDENTITY(1,1) NOT NULL,
[first_name] [varchar](100) NOT NULL,
[second_name] [varchar](100) NOT NULL,
[last_name] [varchar](100) NOT NULL,
[date_employ] [datetime] NULL,
[date_uneploy] [datetime] NULL,
[status] [int] NOT NULL,
[id_dep] [int] NOT NULL,
[id_post] [int] NOT NULL,
CONSTRAINT [PK_persons] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Тест данные
INSERT INTO status (name) VALUES 
('Активный'),
('Уволен'),
('В отпуске');

INSERT INTO posts (name) VALUES 
('Менеджер'),
('Инженер'),
('Бухгалтер'),
('Секретарь');

INSERT INTO deps (name) VALUES 
('Отдел продаж'),
('ИТ отдел'),
('Бухгалтерия'),
('Кадровый отдел');

INSERT INTO persons (first_name, second_name, last_name, date_employ, date_uneploy, status, id_dep, id_post)
VALUES
('Иван','Петрович','Иванов','20220115',NULL,1,1,1),
('Мария','Ивановна','Смирнова','20210310',NULL,1,2,2),
('Петр','Сергеевич','Кузнецов','20200720','20230228',2,1,1),
('Анна','Михайловна','Попова','20230601',NULL,1,3,3),
('Сергей','Александрович','Волков','20191125','20221231',2,2,2),
('Елена','Владимировна','Соколова','20220905',NULL,1,4,4);

-- Процедуры (создавать каждую отдельно)
CREATE PROCEDURE GetEmployeesList
AS
BEGIN
    SELECT 
        p.last_name + ' ' + LEFT(p.first_name,1) + '. ' + LEFT(p.second_name,1) + '.' AS Fio,
        s.name AS Status,
        d.name AS Department,
        po.name AS Post,
        p.date_employ AS DateOfAdm,
        p.date_uneploy AS DateOfDis
    FROM persons p
    JOIN status s ON p.status = s.id
    JOIN deps d ON p.id_dep = d.id
    JOIN posts po ON p.id_post = po.id
    ORDER BY p.last_name, p.first_name, p.second_name;
END;

CREATE PROCEDURE GetEmployeeStatistics
    @StatusId INT = NULL,
    @StartDate DATE,
    @EndDate DATE,
    @IsEmployed BIT
AS
BEGIN
    SELECT 
        date_employ AS Date,
        COUNT(*) AS Count
    FROM persons
    WHERE (@StatusId IS NULL OR status = @StatusId)
      AND @IsEmployed = 1
      AND date_employ BETWEEN @StartDate AND @EndDate
    GROUP BY date_employ

    UNION ALL

    SELECT 
        date_uneploy AS Date,
        COUNT(*) AS Count
    FROM persons
    WHERE (@StatusId IS NULL OR status = @StatusId)
      AND @IsEmployed = 0
      AND date_uneploy BETWEEN @StartDate AND @EndDate
    GROUP BY date_uneploy
    ORDER BY Date;
END;

CREATE PROCEDURE GetStatusesList
AS
BEGIN
    SELECT name FROM status ORDER BY id;
END;

CREATE PROCEDURE GetStatusIdByName
    @StatusName VARCHAR(100)
AS
BEGIN
    SELECT id FROM status WHERE name = @StatusName;
END;

-- Тест процедур
EXEC GetEmployeesList;

-- приём
EXEC GetEmployeeStatistics
    @StatusId = 1,
    @StartDate = '2023-06-01',
    @EndDate = '2025-06-30',
    @IsEmployed = 1;

-- увольнение
EXEC GetEmployeeStatistics
    @StatusId = 2,
    @StartDate = '2023-02-01',
    @EndDate = '2025-06-30',
    @IsEmployed = 0;




