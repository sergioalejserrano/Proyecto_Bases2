/*Se crea el usuario taller con la clave 12345*/
CREATE USER TALLER IDENTIFIED BY 12345 ACCOUNT UNLOCK;
/*Se le asigna el rol de DBA*/
GRANT DBA TO TALLER;