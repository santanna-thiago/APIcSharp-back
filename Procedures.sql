
CREATE PROCEDURE dbo.NewCustomer @name varchar(255), @cpf bigint, @gender varchar(255), @domain_status_Id int, @domain_type_Id int
AS
BEGIN
	INSERT INTO dbo.customers(
		Name, Cpf, Gender, Domain_Status_Id, Domain_Type_Id)
		VALUES(@name, @cpf, @gender, @domain_status_Id, @domain_type_Id)
END



CREATE PROCEDURE dbo.UpdateCustomer @id int, @name varchar(255), @cpf bigint, @gender varchar(255), @domain_status_Id int, @domain_type_Id int
AS
BEGIN
	UPDATE dbo.customers SET Name = @name, Cpf = @cpf, Gender = @gender, Domain_Status_Id = @domain_status_Id, Domain_Type_Id = @domain_type_Id, Updated_At = CURRENT_TIMESTAMP WHERE Id = @id
END


CREATE PROCEDURE dbo.DeleteCustomer @id int
AS
BEGIN
DELETE FROM dbo.customers WHERE Id = @id
END