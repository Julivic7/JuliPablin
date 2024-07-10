--trae todos los datos de la tabla
SELECT * FROM Users
--Medics
INSERT INTO Users VALUES(
,'La Maquina'
, 'Julian'
, 'Jasarevic'
,'j@j.com'
,'holahola'
,GETDATE()
,GETDATE()
,1
)
--Admins
INSERT INTO Users VALUES(
'Admin'
, 'Julian'
, 'Jasarevic'
, 40767314
,'j@j.com'
,'1'
,'ADMINISTRADOR'
,1
,GETDATE()
,GETDATE()

)

--Cambia la clave, cambia la fecha de modificación , actualiza el cambiar clave
UPDATE Usuarios SET
CLAVE = 'jogadinha',  
UpdateUp = getdate(),
cambiarclave = 0
WHERE id = 2


DELETE FROM Users WHERE id = 2


--Insertar valores en las tablas de sintomas

INSERT INTO IllnessSymptom (IllnessId, SymptomId)
VALUES
    -- Asociaciones para Dengue (1002)
    (1002, 29),    -- Fiebre
    (1002, 30),    -- Dolor de Cabeza
    (1002, 31),    -- Dolor en las Articulaciones
    (1002, 32),    -- Dolor muscular
    (1002, 33),    -- Erupciones cutáneas
    (1002, 34),    -- Náuseas/Vómitos
    (1002, 35),    -- Dolor detrás de los ojos
    (1002, 36),    -- Fatiga
    (1002, 37),    -- Conjuntivitis
    (1002, 38),    -- Dificultad para Respirar
    (1002, 39),    -- Dolor de Garganta
    (1002, 40),    -- Congestión nasal
    (1002, 41),    -- Pérdida de Gusto u Olfato
    (1002, 42),    -- Escalofrío
    (1002, 43),    -- Sangrado

    -- Asociaciones para Chikungunya (1003)
    (1003, 29),    -- Fiebre
    (1003, 30),    -- Dolor de Cabeza
    (1003, 31),    -- Dolor en las Articulaciones
    (1003, 32),    -- Dolor muscular
    (1003, 33),    -- Erupciones cutáneas
    (1003, 34),    -- Náuseas/Vómitos
    (1003, 35),    -- Dolor detrás de los ojos
    (1003, 36),    -- Fatiga
    (1003, 37),    -- Conjuntivitis
    (1003, 38),    -- Dificultad para Respirar
    (1003, 39),    -- Dolor de Garganta
    (1003, 40),    -- Congestión nasal
    (1003, 41),    -- Pérdida de Gusto u Olfato
    (1003, 42),    -- Escalofrío
    (1003, 43),    -- Sangrado

    -- Asociaciones para Zika (1004)
    (1004, 29),    -- Fiebre
    (1004, 30),    -- Dolor de Cabeza
    (1004, 31),    -- Dolor en las Articulaciones
    (1004, 32),    -- Dolor muscular
    (1004, 33),    -- Erupciones cutáneas
    (1004, 34),    -- Náuseas/Vómitos
    (1004, 35),    -- Dolor detrás de los ojos
    (1004, 36),    -- Fatiga
    (1004, 37),    -- Conjuntivitis
    (1004, 38),    -- Dificultad para Respirar
    (1004, 39),    -- Dolor de Garganta
    (1004, 40),    -- Congestión nasal
    (1004, 41),    -- Pérdida de Gusto u Olfato
    (1004, 42),    -- Escalofrío
    (1004, 43),    -- Sangrado

    -- Asociaciones para Neumonía (1005)
    (1005, 29),    -- Fiebre
    (1005, 30),    -- Dolor de Cabeza
    (1005, 31),    -- Dolor en las Articulaciones
    (1005, 32),    -- Dolor muscular
    (1005, 34),    -- Náuseas/Vómitos
    (1005, 36),    -- Fatiga
    (1005, 38),    -- Dificultad para Respirar
    (1005, 39),    -- Dolor de Garganta
    (1005, 40),    -- Congestión nasal

    -- Asociaciones para Covid (1006)
    (1006, 29),    -- Fiebre
    (1006, 30),    -- Dolor de Cabeza
    (1006, 31),    -- Dolor en las Articulaciones
    (1006, 32),    -- Dolor muscular
    (1006, 33),    -- Erupciones cutáneas
    (1006, 34),    -- Náuseas/Vómitos
    (1006, 35),    -- Dolor detrás de los ojos
    (1006, 36),    -- Fatiga
    (1006, 37),    -- Conjuntivitis
    (1006, 38),    -- Dificultad para Respirar
    (1006, 39),    -- Dolor de Garganta
    (1006, 40),    -- Congestión nasal
    (1006, 41),    -- Pérdida de Gusto u Olfato
    (1006, 42),    -- Escalofrío
    (1006, 43),    -- Sangrado

    -- Asociaciones para Resfriado común (1007)
    (1007, 29),    -- Fiebre
    (1007, 30),    -- Dolor de Cabeza
    (1007, 32),    -- Dolor muscular
    (1007, 34),    -- Náuseas/Vómitos
    (1007, 36),    -- Fatiga
    (1007, 38),    -- Dificultad para Respirar
    (1007, 39),    -- Dolor de Garganta
    (1007, 40);    -- Congestión nasal
