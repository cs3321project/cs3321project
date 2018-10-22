CREATE TABLE [dbo].[studentData_Chris] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [student_ID]   INT          NULL,
    [student_Name] VARCHAR (50) NULL,
    [Exam1]        INT          NULL,
    [Exam2]        INT          NULL,
    [Exam3]        INT          NULL,
	[Exam4]        INT          NULL,
    [Class AVG]    DECIMAL (18) NULL,
    [Course]      VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

