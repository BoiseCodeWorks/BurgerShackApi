USE burgershack6;
DROP TABLE burgers;

-- SECTION  ----- Startup Commands -----

-- NOTE Creating a new table
-- CREATE TABLE burgers (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(255) NOT NULL,
--     description VARCHAR(255),
--     price DECIMAL DEFAULT 0,
--     PRIMARY KEY (id)
-- );

-- ALTER TABLE burgers MODIFY price DECIMAL DEFAULT 0;





-- NOTE Add to table (on db) Create
-- INSERT INTO burgers (name, description) VALUES ("Mark", "A CHEESY tasty burger");
-- INSERT INTO burgers (description, name) VALUES ("A Kinda CHEESY kinda tasty burger", "Jake");
-- INSERT INTO burgers (name, description) VALUES ("D$", "All the meats");
-- INSERT INTO burgers (name, description) VALUES ("Porter2", "Its Veggies gross");


-- NOTE GetALL
-- SELECT * FROM burgers;

-- NOTE GetById
-- SELECT * FROM burgers WHERE id = 2;

-- NOTE Edit
-- UPDATE burgers
-- SET
--     name = "Mark Deluxe",
--     price = 13.01
-- WHERE id = 1;

-- NOTE DELETE
-- DELETE FROM burgers WHERE id = 14;







-- SECTION  ----- DANGER ZONE --------------
-- DELETE FROM burgers  DELETES ALL THE DATA
-- DROP TABLE burgers -- DELETES THE TABLE AND ITS CONTENTS
-- DROP DATABASE