CREATE PROCEDURE SaveandUpdateExamData
	@Exam1 int,
	@Exam2 int,
	@Exam3 int,
	@Exam4 int
AS
	INSERT INTO studentData_Chris(student_Name,Exam1,Exam2,Exam3,Exam4) VALUES(@Exam1,@Exam2,@Exam3,@Exam4)
	
	
	

RETURN 0
