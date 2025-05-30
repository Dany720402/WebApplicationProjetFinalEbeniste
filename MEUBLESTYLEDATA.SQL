USE [DB_PRODUIT]
GO


INSERT INTO styles (NOM) VALUES ('RUSTIQUE');



INSERT INTO Meubles (Nom, Description, StyleID, Prix, TypeDeBois, DateCreation, imageURL) VALUES 
('Chaise Scandinave', 'Chaise en bois clair avec un design épuré typique du style nordique. Parfaite pour une salle à manger moderne.', 1, 129.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/product-3.png'),
('Nordic Chair', 'Chaise en bois clair avec un design épuré typique du style nordique. Parfaite pour une salle à manger moderne.', 1, 159.90, 'Chêne', '2025-04-23 10:30:00.000', 'images/product-1.png'),
('Kruzo Aero Chair', 'Chaise en bois clair avec un design épuré typique du style nordique. Parfaite pour une salle à manger moderne.', 1, 139.90, 'Chêne', '2025-04-23 10:30:00.000', 'images/product-2.png'),
('Ergonomic Chair', 'Chaise en bois clair avec un design épuré typique du style nordique. Parfaite pour une salle à manger moderne.', 1, 189.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/product-3.png'),
('Bureau 1', 'Bureau en bois clair', 1, 389.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/image1.jpeg'),
('Bureau 2', 'Bureau en bois clair', 1, 589.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/image2.jpeg'),
('Bureau 3', 'Bureau en bois clair', 1, 489.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/image3.jpeg'),
('Table 1', 'Bureau en bois clair', 1, 689.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/img1.jpeg'),
('Table 2', 'Bureau en bois clair', 1, 689.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/img2.jpeg'),
('Bureau 4', 'Bureau en bois clair', 1, 789.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/img3.jpeg'),
('Bibliothèque 1', 'Bureau en bois clair', 1, 789.99, 'Chêne', '2025-04-23 10:30:00.000', 'images/img4.jpeg');