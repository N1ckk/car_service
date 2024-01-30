/*
 Navicat Premium Data Transfer

 Source Server         : Local instance MySQL80
 Source Server Type    : MySQL
 Source Server Version : 80031 (8.0.31)
 Source Host           : localhost:3306
 Source Schema         : car_service

 Target Server Type    : MySQL
 Target Server Version : 80031 (8.0.31)
 File Encoding         : 65001

 Date: 30/01/2024 20:02:24
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for car_brand
-- ----------------------------
DROP TABLE IF EXISTS `car_brand`;
CREATE TABLE `car_brand`  (
  `id_b` int NOT NULL AUTO_INCREMENT,
  `brand` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_b`) USING BTREE,
  UNIQUE INDEX `car_brand_UNIQUE`(`brand` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of car_brand
-- ----------------------------
INSERT INTO `car_brand` VALUES (3, 'Audi');
INSERT INTO `car_brand` VALUES (6, 'BMW');
INSERT INTO `car_brand` VALUES (1, 'Chevrolet');
INSERT INTO `car_brand` VALUES (5, 'Daewoo');
INSERT INTO `car_brand` VALUES (7, 'Opel');
INSERT INTO `car_brand` VALUES (2, 'Porsche');
INSERT INTO `car_brand` VALUES (4, 'Reno');

-- ----------------------------
-- Table structure for car_brand_model
-- ----------------------------
DROP TABLE IF EXISTS `car_brand_model`;
CREATE TABLE `car_brand_model`  (
  `id_mm` int NOT NULL AUTO_INCREMENT,
  `id_b` int NULL DEFAULT NULL,
  `id_m` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_mm`) USING BTREE,
  INDEX `id_b`(`id_b` ASC) USING BTREE,
  INDEX `id_m`(`id_m` ASC) USING BTREE,
  CONSTRAINT `car_brand_model_ibfk_1` FOREIGN KEY (`id_b`) REFERENCES `car_brand` (`id_b`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `car_brand_model_ibfk_2` FOREIGN KEY (`id_m`) REFERENCES `car_model` (`id_m`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 13 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of car_brand_model
-- ----------------------------
INSERT INTO `car_brand_model` VALUES (1, 1, 1);
INSERT INTO `car_brand_model` VALUES (2, 2, 2);
INSERT INTO `car_brand_model` VALUES (3, 3, 3);
INSERT INTO `car_brand_model` VALUES (4, 4, 4);
INSERT INTO `car_brand_model` VALUES (5, 5, 5);
INSERT INTO `car_brand_model` VALUES (6, 3, 7);
INSERT INTO `car_brand_model` VALUES (7, 6, 9);
INSERT INTO `car_brand_model` VALUES (8, 1, 10);
INSERT INTO `car_brand_model` VALUES (9, 6, 8);
INSERT INTO `car_brand_model` VALUES (10, 7, 6);

-- ----------------------------
-- Table structure for car_model
-- ----------------------------
DROP TABLE IF EXISTS `car_model`;
CREATE TABLE `car_model`  (
  `id_m` int NOT NULL AUTO_INCREMENT,
  `model` varchar(70) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id_m`) USING BTREE,
  UNIQUE INDEX `model`(`model` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of car_model
-- ----------------------------
INSERT INTO `car_model` VALUES (3, 'A6');
INSERT INTO `car_model` VALUES (1, 'Aveo');
INSERT INTO `car_model` VALUES (10, 'Camaro');
INSERT INTO `car_model` VALUES (2, 'Cayenne');
INSERT INTO `car_model` VALUES (4, 'Clio');
INSERT INTO `car_model` VALUES (6, 'Corsa');
INSERT INTO `car_model` VALUES (5, 'Lanos');
INSERT INTO `car_model` VALUES (8, 'M5');
INSERT INTO `car_model` VALUES (7, 'Q7');
INSERT INTO `car_model` VALUES (9, 'X5M');

-- ----------------------------
-- Table structure for client
-- ----------------------------
DROP TABLE IF EXISTS `client`;
CREATE TABLE `client`  (
  `id_c` int NOT NULL AUTO_INCREMENT,
  `c_full_name` varchar(55) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `c_mob_number` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id_c`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 37 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of client
-- ----------------------------
INSERT INTO `client` VALUES (1, 'Вовк Ростислав Гаврилович\r\n\r\n\r\n\r\n', '+380677151312\r\n\r\n\r\n\r\n');
INSERT INTO `client` VALUES (2, 'Бурлака Казимир Юхимович\r\nБурлака Казимир Юхимович\r\n', '+380504151398\r\n+380504151398\r\n');
INSERT INTO `client` VALUES (3, 'Чебан Леонід Олексійович', '+380674257818');
INSERT INTO `client` VALUES (4, 'Добровольський Ростислав Валерійович', '+380444177811');
INSERT INTO `client` VALUES (5, 'Коломієць Валерій Іванович', '+380972357823');
INSERT INTO `client` VALUES (6, 'Гавриленко Алла Іллівна', '+380972857421');
INSERT INTO `client` VALUES (7, 'Андрійчук Станіслав Васильович', '+380571131777');
INSERT INTO `client` VALUES (8, 'Карпенко Вячеслав Броніславович', '+380671231881');
INSERT INTO `client` VALUES (9, 'Ситник Дмитро Вадимович', '+380523431125');
INSERT INTO `client` VALUES (10, 'Хоменко Анастасія Святославівна', '+380523034210');
INSERT INTO `client` VALUES (11, 'Маркевич Євген Остапович', '+380672125827');
INSERT INTO `client` VALUES (12, 'Вовченко Ростислав Гаврилович\r\n', '+380504525891\r\n');
INSERT INTO `client` VALUES (13, 'Шевченко Максим Олегович', '+380975300253');
INSERT INTO `client` VALUES (14, 'Коваленко Петро Олексійович', '+380972040777');
INSERT INTO `client` VALUES (15, 'Миколенко Антон Антонович', '+380973050555');
INSERT INTO `client` VALUES (16, 'Михайличенко Андрій Вікторович', '+380507854333');
INSERT INTO `client` VALUES (17, 'Зінченко Микола Петрович', '+380672478932');
INSERT INTO `client` VALUES (18, 'Коваленко Олександр Дмитрович', '+380504356789');
INSERT INTO `client` VALUES (19, 'Трунов Данило Володимирович', '+380504357888');
INSERT INTO `client` VALUES (20, 'Шевченко Михайло Максимович', '+380507234543');
INSERT INTO `client` VALUES (21, 'Коваленко', '+380503040532');
INSERT INTO `client` VALUES (22, 'Зеленов', '+380972040521');
INSERT INTO `client` VALUES (23, 'Марченко Віталй Віталійович\r\n\r\n', '+380674325344\r\n\r\n');
INSERT INTO `client` VALUES (24, 'Віталенко Микола Микитович\r\n\r\n\r\n\r\n', '+380635467888\r\n\r\n\r\n\r\n');
INSERT INTO `client` VALUES (25, 'Коваленко Микола Вікторович\r\n', '+380975434555\r\n');
INSERT INTO `client` VALUES (26, 'f\r\n', '+380974567888\r\n');
INSERT INTO `client` VALUES (27, 'Михайличенко Богдан Вікторович\r\n\r\n', '+380674323444\r\n\r\n');
INSERT INTO `client` VALUES (28, 'Сірий Іван Петрович', '+380674532111');
INSERT INTO `client` VALUES (29, 'а\r\n\r\n\r\n', '+380975432444\r\n\r\n\r\n');
INSERT INTO `client` VALUES (30, 'f\r\n\r\n', '+380974532111\r\n\r\n');
INSERT INTO `client` VALUES (31, 'Михайленко Віктор Петрович\r\n\r\n\r\n', '+380975040777\r\n\r\n\r\n');
INSERT INTO `client` VALUES (32, 'g\r\n\r\n', '+380972040555\r\n\r\n');
INSERT INTO `client` VALUES (33, 'Миколенко Петро Олексійович\r\n', '+380674323444\r\n');
INSERT INTO `client` VALUES (34, 'Миколенкоо Петро Олексійович\r\n\r\n', '+380674323444\r\n\r\n');
INSERT INTO `client` VALUES (35, 'М\r\n', '+380674555777\r\n');
INSERT INTO `client` VALUES (36, 'Миколенко Віктор Федорович', '+380974323444');

-- ----------------------------
-- Table structure for consumption
-- ----------------------------
DROP TABLE IF EXISTS `consumption`;
CREATE TABLE `consumption`  (
  `id_co` int NOT NULL AUTO_INCREMENT,
  `id_c` int NULL DEFAULT NULL,
  `date_acceptance` date NOT NULL,
  `id_em` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_co`) USING BTREE,
  INDEX `id_c`(`id_c` ASC) USING BTREE,
  INDEX `id_em`(`id_em` ASC) USING BTREE,
  CONSTRAINT `consumption_ibfk_1` FOREIGN KEY (`id_c`) REFERENCES `client` (`id_c`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `consumption_ibfk_2` FOREIGN KEY (`id_em`) REFERENCES `employee` (`id_em`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 34 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of consumption
-- ----------------------------
INSERT INTO `consumption` VALUES (1, 5, '2023-02-09', 3);
INSERT INTO `consumption` VALUES (2, 7, '2023-04-21', 4);
INSERT INTO `consumption` VALUES (3, 1, '2023-02-15', 11);
INSERT INTO `consumption` VALUES (4, 3, '2023-02-24', 8);
INSERT INTO `consumption` VALUES (5, 9, '2023-01-04', 1);
INSERT INTO `consumption` VALUES (6, 2, '2023-03-07', 8);
INSERT INTO `consumption` VALUES (7, 4, '2022-12-03', 3);
INSERT INTO `consumption` VALUES (8, 6, '2023-03-03', 11);
INSERT INTO `consumption` VALUES (9, 8, '2023-03-15', 1);
INSERT INTO `consumption` VALUES (10, 10, '2023-04-07', 4);
INSERT INTO `consumption` VALUES (11, 11, '2023-03-05', 11);
INSERT INTO `consumption` VALUES (12, 1, '2023-04-05', 1);
INSERT INTO `consumption` VALUES (13, 14, '2023-05-22', 1);
INSERT INTO `consumption` VALUES (14, 17, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (15, 18, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (16, 19, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (17, 20, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (18, 21, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (19, 22, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (20, 23, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (21, 24, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (22, 25, '2023-05-23', 1);
INSERT INTO `consumption` VALUES (23, 26, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (24, 27, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (25, 28, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (26, 29, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (27, 30, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (28, 31, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (29, 32, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (30, 33, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (31, 34, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (32, 35, '2023-05-24', 1);
INSERT INTO `consumption` VALUES (33, 36, '2023-05-24', 1);

-- ----------------------------
-- Table structure for consumption_details
-- ----------------------------
DROP TABLE IF EXISTS `consumption_details`;
CREATE TABLE `consumption_details`  (
  `id_cod` int NOT NULL AUTO_INCREMENT,
  `id_co` int NULL DEFAULT NULL,
  `id_d` int NULL DEFAULT NULL,
  `c_quantity` int NOT NULL,
  PRIMARY KEY (`id_cod`) USING BTREE,
  INDEX `id_co`(`id_co` ASC) USING BTREE,
  INDEX `id_d`(`id_d` ASC) USING BTREE,
  CONSTRAINT `consumption_details_ibfk_1` FOREIGN KEY (`id_co`) REFERENCES `consumption` (`id_co`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `consumption_details_ibfk_2` FOREIGN KEY (`id_d`) REFERENCES `details` (`id_d`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 34 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of consumption_details
-- ----------------------------
INSERT INTO `consumption_details` VALUES (1, 5, 9, 1);
INSERT INTO `consumption_details` VALUES (2, 7, 4, 2);
INSERT INTO `consumption_details` VALUES (3, 1, 2, 1);
INSERT INTO `consumption_details` VALUES (4, 3, 8, 1);
INSERT INTO `consumption_details` VALUES (5, 9, 7, 2);
INSERT INTO `consumption_details` VALUES (6, 2, 10, 1);
INSERT INTO `consumption_details` VALUES (7, 4, 1, 1);
INSERT INTO `consumption_details` VALUES (8, 6, 3, 2);
INSERT INTO `consumption_details` VALUES (9, 8, 6, 1);
INSERT INTO `consumption_details` VALUES (10, 10, 9, 1);
INSERT INTO `consumption_details` VALUES (11, 11, 1, 2);
INSERT INTO `consumption_details` VALUES (13, 13, 5, 1);
INSERT INTO `consumption_details` VALUES (14, 14, 1, 1);
INSERT INTO `consumption_details` VALUES (15, 15, 7, 2);
INSERT INTO `consumption_details` VALUES (16, 16, 5, 2);
INSERT INTO `consumption_details` VALUES (17, 17, 2, 2);
INSERT INTO `consumption_details` VALUES (18, 18, 9, 2);
INSERT INTO `consumption_details` VALUES (19, 19, 11, 2);
INSERT INTO `consumption_details` VALUES (20, 20, 2, 1);
INSERT INTO `consumption_details` VALUES (21, 21, 1, 1);
INSERT INTO `consumption_details` VALUES (22, 22, 8, 1);
INSERT INTO `consumption_details` VALUES (23, 23, 1, 1);
INSERT INTO `consumption_details` VALUES (24, 24, 5, 1);
INSERT INTO `consumption_details` VALUES (25, 25, 2, 2);
INSERT INTO `consumption_details` VALUES (26, 26, 11, 1);
INSERT INTO `consumption_details` VALUES (27, 27, 1, 1);
INSERT INTO `consumption_details` VALUES (28, 28, 1, 1);
INSERT INTO `consumption_details` VALUES (29, 29, 4, 3);
INSERT INTO `consumption_details` VALUES (30, 30, 6, 1);
INSERT INTO `consumption_details` VALUES (31, 31, 1, 1);
INSERT INTO `consumption_details` VALUES (32, 32, 2, 2);
INSERT INTO `consumption_details` VALUES (33, 33, 6, 1);

-- ----------------------------
-- Table structure for details
-- ----------------------------
DROP TABLE IF EXISTS `details`;
CREATE TABLE `details`  (
  `id_d` int NOT NULL AUTO_INCREMENT,
  `id_mm` int NULL DEFAULT NULL,
  `name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` varchar(130) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `quantity` int NOT NULL,
  `price_d` int NOT NULL,
  PRIMARY KEY (`id_d`) USING BTREE,
  INDEX `id_mm_idx`(`id_mm` ASC) USING BTREE,
  CONSTRAINT `id_mm` FOREIGN KEY (`id_mm`) REFERENCES `car_brand_model` (`id_mm`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of details
-- ----------------------------
INSERT INTO `details` VALUES (1, 5, 'Глушник', 'У зборі, алюмінійований (протипригарне покриття). Бочка глушника 2-х шарова', 18, 462);
INSERT INTO `details` VALUES (2, 1, 'Свіча запалювання', 'Відстань між електродами: 0,9 Техніка приєднання: M4/SAE Розмір різьблення: M14x1.25', 8, 734);
INSERT INTO `details` VALUES (3, 4, 'Фара ліва', 'Фара передня для Renault Clio 2 / Symbol 01-08 ліва, електрич., сіра H7/H1', 11, 360);
INSERT INTO `details` VALUES (4, 2, 'Фара права', 'Фара права фул лед Porsche Cayenne IIІ 9Y0 (PO536) (2017-2021) дорестайл.1', 10, 420);
INSERT INTO `details` VALUES (5, 3, 'Півкільце', 'Напівкільця упорні VAG STD 2,6/2,8/3,0/2,5TDi V6 (вир-во KS)', 4, 360);
INSERT INTO `details` VALUES (6, 8, 'Ковпачок колісного диска', 'Ковпаки SKS з логотипом', 19, 240);
INSERT INTO `details` VALUES (7, 9, 'Комплект прокладок', 'Комплект прокладок двигуна верхній на BMW M5 (2017 - 2023), 525i 24V бензин', 8, 480);
INSERT INTO `details` VALUES (8, 10, 'Форсунка', 'Клапанна форсунка BOSCH', 2, 720);
INSERT INTO `details` VALUES (9, 6, 'Сигнал звуковий', 'Cигнал звуковий Audi Q7: високий тон', 4, 630);
INSERT INTO `details` VALUES (10, 7, 'Підголівники', 'Підголівники комплект LCI BMW Х5M', 9, 240);
INSERT INTO `details` VALUES (11, 7, 'Глушник', 'Глушник вихлопний BMW X5 F15 3.0 D M-Pакіет кінцевий', 1, 240);
INSERT INTO `details` VALUES (12, 9, 'Глушник', 'Глушник', 0, 0);
INSERT INTO `details` VALUES (13, 1, 'Глушник', 'Глушник', 0, 0);
INSERT INTO `details` VALUES (14, 5, 'Глушник', 'Глушник', 0, 0);

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `id_em` int NOT NULL AUTO_INCREMENT,
  `e_full_name` varchar(55) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `position` varchar(40) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  `e_mob_number` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_em`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 14 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (1, 'Шевченко Лев Андрійович', 'Автомеханік', '+380675122353');
INSERT INTO `employee` VALUES (2, 'Васильчук Дар\'я  Михайлівна', 'Менеджер', '+380505132777');
INSERT INTO `employee` VALUES (3, 'Дмитренко Ярослав Валентинович', 'Автомаляр', '+380505595123');
INSERT INTO `employee` VALUES (4, 'Пономарчук Данило Олександрович', 'Автоелектрик', '+380975723155');
INSERT INTO `employee` VALUES (5, 'Кудрявцев Богдан Олександрович', 'Автоелектрик', '+380682153105');
INSERT INTO `employee` VALUES (6, 'Шинкаренко Артем Олексійович', 'Бухгалтер', '+380682957243');
INSERT INTO `employee` VALUES (7, 'Крамаренко Марія Василівна', 'Бухгалтер', '+380502155247');
INSERT INTO `employee` VALUES (8, 'Антоненко Дмитро Олексійович', 'Майстер кузовного ремонту', '+3809721552155');
INSERT INTO `employee` VALUES (9, 'Пономаренко Дмитро Васильович', 'Юрист', '+3809721536901');
INSERT INTO `employee` VALUES (10, 'Валерій Миколайович Мірошниченко', 'Фінансовий директор', '+3805043537891');
INSERT INTO `employee` VALUES (11, 'Васильчук Вадим Олександрович', 'Автомеханік', '+3809745321700');
INSERT INTO `employee` VALUES (12, 'Боднаренко Валентин Євгенійович', 'Директор', '+3805035301000');
INSERT INTO `employee` VALUES (13, 'Красинець Добриня Романович', 'Заступник директора', '+3805035322232');

-- ----------------------------
-- Table structure for supplie_details
-- ----------------------------
DROP TABLE IF EXISTS `supplie_details`;
CREATE TABLE `supplie_details`  (
  `id_dd` int NOT NULL AUTO_INCREMENT,
  `id_del` int NULL DEFAULT NULL,
  `id_d` int NULL DEFAULT NULL,
  `price` int NOT NULL,
  `s_quantity` int NOT NULL,
  PRIMARY KEY (`id_dd`) USING BTREE,
  INDEX `id_del`(`id_del` ASC) USING BTREE,
  INDEX `id_d`(`id_d` ASC) USING BTREE,
  CONSTRAINT `supplie_details_ibfk_1` FOREIGN KEY (`id_del`) REFERENCES `supplies` (`id_del`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `supplie_details_ibfk_2` FOREIGN KEY (`id_d`) REFERENCES `details` (`id_d`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of supplie_details
-- ----------------------------
INSERT INTO `supplie_details` VALUES (1, 10, 1, 500, 20);
INSERT INTO `supplie_details` VALUES (2, 12, 11, 200, 2);
INSERT INTO `supplie_details` VALUES (3, 13, 2, 200, 2);
INSERT INTO `supplie_details` VALUES (4, 14, 1, 200, 2);
INSERT INTO `supplie_details` VALUES (5, 3, 7, 400, 15);
INSERT INTO `supplie_details` VALUES (6, 7, 9, 600, 5);
INSERT INTO `supplie_details` VALUES (7, 11, 1, 200, 2);
INSERT INTO `supplie_details` VALUES (8, 9, 8, 600, 4);
INSERT INTO `supplie_details` VALUES (9, 4, 4, 350, 15);
INSERT INTO `supplie_details` VALUES (10, 8, 2, 750, 10);
INSERT INTO `supplie_details` VALUES (11, 1, 3, 300, 13);
INSERT INTO `supplie_details` VALUES (12, 2, 5, 300, 11);
INSERT INTO `supplie_details` VALUES (13, 5, 10, 200, 10);
INSERT INTO `supplie_details` VALUES (14, 6, 6, 200, 12);
INSERT INTO `supplie_details` VALUES (15, 15, 9, 400, 3);
INSERT INTO `supplie_details` VALUES (16, 16, 6, 200, 10);
INSERT INTO `supplie_details` VALUES (17, 17, 2, 500, 5);
INSERT INTO `supplie_details` VALUES (18, 18, 1, 230, 10);

-- ----------------------------
-- Table structure for supplies
-- ----------------------------
DROP TABLE IF EXISTS `supplies`;
CREATE TABLE `supplies`  (
  `id_del` int NOT NULL AUTO_INCREMENT,
  `id_sw` int NULL DEFAULT NULL,
  `date_supplies` date NOT NULL,
  `id_em` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_del`) USING BTREE,
  INDEX `id_sw`(`id_sw` ASC) USING BTREE,
  INDEX `id_em`(`id_em` ASC) USING BTREE,
  CONSTRAINT `supplies_ibfk_1` FOREIGN KEY (`id_sw`) REFERENCES `supply_workers` (`id_sw`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `supplies_ibfk_2` FOREIGN KEY (`id_em`) REFERENCES `employee` (`id_em`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of supplies
-- ----------------------------
INSERT INTO `supplies` VALUES (1, 7, '2023-03-04', 12);
INSERT INTO `supplies` VALUES (2, 8, '2022-10-21', 12);
INSERT INTO `supplies` VALUES (3, 1, '2023-03-01', 10);
INSERT INTO `supplies` VALUES (4, 4, '2022-11-27', 13);
INSERT INTO `supplies` VALUES (5, 8, '2023-02-22', 13);
INSERT INTO `supplies` VALUES (6, 9, '2023-02-14', 12);
INSERT INTO `supplies` VALUES (7, 2, '2023-03-13', 10);
INSERT INTO `supplies` VALUES (8, 5, '2023-01-27', 10);
INSERT INTO `supplies` VALUES (9, 3, '2023-01-10', 12);
INSERT INTO `supplies` VALUES (10, 7, '2023-01-14', 12);
INSERT INTO `supplies` VALUES (11, 2, '2023-04-04', 13);
INSERT INTO `supplies` VALUES (12, 1, '2023-03-05', 10);
INSERT INTO `supplies` VALUES (13, 1, '2023-03-05', 10);
INSERT INTO `supplies` VALUES (14, 1, '2023-03-05', 10);
INSERT INTO `supplies` VALUES (15, 1, '2023-05-22', 10);
INSERT INTO `supplies` VALUES (16, 3, '2023-05-23', 10);
INSERT INTO `supplies` VALUES (17, 2, '2023-05-24', 10);
INSERT INTO `supplies` VALUES (18, 7, '2023-05-24', 10);

-- ----------------------------
-- Table structure for supply_workers
-- ----------------------------
DROP TABLE IF EXISTS `supply_workers`;
CREATE TABLE `supply_workers`  (
  `id_sw` int NOT NULL AUTO_INCREMENT,
  `s_full_name` varchar(55) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `adress` varchar(60) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `s_mob_number` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id_sw`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 12 CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of supply_workers
-- ----------------------------
INSERT INTO `supply_workers` VALUES (1, 'Сорокін Матвій Євгенович', 'вул. Ірпінська, 5', '+380322442884');
INSERT INTO `supply_workers` VALUES (2, 'Володимиров Артем Марсельович', 'вул. Героїв Харкова, 100', '+380970500129');
INSERT INTO `supply_workers` VALUES (3, 'Бєляєв Микита Максимович', 'вул. Пальміро Тольятті, 15', '+380971462137');
INSERT INTO `supply_workers` VALUES (4, 'Рубценко Олександр Кирилович', 'вул. Рузвельта, 2', '+380503332157');
INSERT INTO `supply_workers` VALUES (5, 'Бородіна Анастасія Микитівна', 'вул. Одеська, 3А', '+380672152177');
INSERT INTO `supply_workers` VALUES (6, 'Алексєєва Софія Богданівна', 'вул. Познанська, 10Б', '+380504132122');
INSERT INTO `supply_workers` VALUES (7, 'Зінченко Михайло Артемович', 'вул. Левицького, 95', '+380441452131');
INSERT INTO `supply_workers` VALUES (8, 'Фокін Олександр Федорович', 'просп. Шевченка, 100', '+380972351555');
INSERT INTO `supply_workers` VALUES (9, 'Ковальов Артем Олексійович', 'вул. Сумська, 19', '+380971351777');
INSERT INTO `supply_workers` VALUES (10, 'Коваленко Олексій Максимович', 'вул. Сумська, 27', '+380501323147');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `id_u` int NOT NULL,
  `id_c` int NULL DEFAULT NULL,
  `u_login` varchar(55) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `password` varchar(75) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `role` varchar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`id_u`) USING BTREE,
  INDEX `id_c_idx`(`id_c` ASC) USING BTREE,
  CONSTRAINT `id_c` FOREIGN KEY (`id_c`) REFERENCES `client` (`id_c`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb3 COLLATE = utf8mb3_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 4, 'fary', '1a2s3d4F', 'user');
INSERT INTO `users` VALUES (2, 5, 'admin', 'admin', 'admin');
INSERT INTO `users` VALUES (3, 2, 'ben', 'dasd3Fa0', 'user');
INSERT INTO `users` VALUES (4, 8, 'mary', '1a2s3D05', 'user');
INSERT INTO `users` VALUES (5, 7, 'kevin', 'KlAd123', 'user');
INSERT INTO `users` VALUES (6, 35, 'client2', 'client', 'user');
INSERT INTO `users` VALUES (7, 11, 'cgdg', '1a2s3d', 'user');
INSERT INTO `users` VALUES (8, 1, 'client', 'client', 'user');

-- ----------------------------
-- Procedure structure for add_auto
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_auto`;
delimiter ;;
CREATE PROCEDURE `add_auto`(car_brand varchar(50), car_model varchar(70))
begin
declare im, imm, ib  int;
if exists(select brand from car_brand where brand = car_brand) and exists(select model from car_model where model = car_model)
and (not exists(select id_mm from car_brand_model join car_brand using(id_b) join car_model using(id_m) where brand=car_brand and model=car_model)) then
set ib = (select id_b from car_brand where brand=car_brand);
set im = (select id_m from car_model where model=car_model); 
set imm = (select Count(*) from car_brand_model);
set imm = imm + 1;
insert into car_brand_model values (imm, ib, im);
end if;
if  (not exists(select brand from car_brand where brand = car_brand)) and (not exists(select model from car_model where model = car_model)) then
set ib = (select count(*) from car_brand);
set ib = ib + 1;
set im = (select count(*) from car_model);
set im = im + 1;
set imm = (select count(*) from car_brand_model);
set imm = imm + 1;
insert into car_brand values (ib, car_brand);
insert into car_model values (im, car_model);
insert into car_brand_model values (imm, ib, im);
end if;
if exists(select brand from car_brand where brand = car_brand) and not exists(select model from car_model where model = car_model) then
set ib = (select id_b from car_brand where brand=car_brand);
set im = (select count(*) from car_model);
set im = im + 1;
set imm = (select count(*) from car_brand_model);
set imm = imm + 1;
insert into car_model values (im, car_model);
insert into car_brand_model values (imm, ib, im);
end if;
if not exists(select brand from car_brand where brand = car_brand) and exists(select model from car_model where model = car_model) then
set ib = (select count(*) from car_brand);
set ib = ib + 1;
set im = (select id_m from car_model where model = car_model);
set imm = (select count(*) from car_brand_model);
set imm = imm + 1;
insert into car_brand values (ib, car_brand);
insert into car_brand_model values (imm, ib, im);
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_brand
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_brand`;
delimiter ;;
CREATE PROCEDURE `add_brand`(car_b varchar(50))
begin
declare ib int;
set ib = (select Count(*) from car_brand);
set ib = ib + 1;
insert into car_brand values (ib, car_b);
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_detail
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_detail`;
delimiter ;;
CREATE PROCEDURE `add_detail`(namee varchar(50), des varchar(120), car_b varchar(50), car_m varchar(70))
begin
declare i, im int;
set i = (select Count(*) from details);
set i = i + 1;
set im = (select id_mm from car_brand_model join car_brand using (id_b) 
join car_model using (id_m) where brand = car_b and model = car_m);
insert into details values (i, im, namee, des, 0, 0);
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_employee
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_employee`;
delimiter ;;
CREATE PROCEDURE `add_employee`(full varchar(55), pos varchar(40), number varchar(30))
begin
declare id int;
set id = (select count(*) from employee);
set id = id + 1;
if(not exists(select e_full_name from employee where e_full_name = full_n)) then
insert into employee values(id, full, pos, number);
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_fio
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_fio`;
delimiter ;;
CREATE PROCEDURE `add_fio`(full varchar(55), login varchar(55))
begin
declare id, idc int;
set id = (select id_u from users where login = u_login);
set idc = (select id_c from client where full = c_full_name);
if(not exists(select e_full_name from employee where e_full_name = full)) then
update users set id_c = idc where id_u = id;
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_model
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_model`;
delimiter ;;
CREATE PROCEDURE `add_model`(car_m varchar(70))
begin
declare im int;
set im = (select Count(*) from car_model);
set im = im + 1;
insert into car_model values (im, car_m);
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for add_supplier
-- ----------------------------
DROP PROCEDURE IF EXISTS `add_supplier`;
delimiter ;;
CREATE PROCEDURE `add_supplier`(sfn varchar(50), adress varchar(60), sphone varchar(30))
begin
declare i int;
set i = (select Count(*) from supply_workers);
set i = i + 1;
insert into supply_workers values (i, sfn, adress, sphone);
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for consumption_details
-- ----------------------------
DROP PROCEDURE IF EXISTS `consumption_details`;
delimiter ;;
CREATE PROCEDURE `consumption_details`(monthh int)
begin
select id_d as Код, name as Назва, description as Опис, brand as Марка, model as Модель, date_acceptance as ДатаЗамовлення, c_quantity as Кількість, 
price_d as ЦінаЗа1Од, price_d*c_quantity as ЗагЦіна from details join car_brand_model using(id_mm) 
join car_brand using (id_b) join car_model using (id_m)
join consumption_details using (id_d)  join consumption using(id_co) where month(date_acceptance)=monthh;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for editOrder
-- ----------------------------
DROP PROCEDURE IF EXISTS `editOrder`;
delimiter ;;
CREATE PROCEDURE `editOrder`(full_n varchar(55), car_b varchar(50), car_m varchar(70), mobile varchar(30), named varchar(50),q int,q1 int)
begin
declare pr, pr1, idd,idc,idco,idcod, ide,a, pric_e int;
set idd=(select id_d from details join car_brand_model using (id_mm) join car_brand using (id_b)
join car_model using(id_m) where named=name and brand = car_b and model = car_m and quantity<>0);
set idc=(select id_mm from car_brand_model join car_brand using (id_b) join car_model using (id_m) where brand = car_b and model=car_m);
set idco = (select count(1) from consumption);
set idcod = (select count(*) from consumption_details);
set idcod = idcod + 1;
set ide = (select id_em from employee where position='Автомеханік' limit 1);
set pr = (select count(1) from client);
set a=(select quantity from details join car_brand_model using(id_mm) join car_brand using (id_b) join 
car_model using (id_m) where name = named and brand = car_b and model = car_m);
set pr1 = (select id_c from client where c_full_name = full_n);
if (a<>0 and a-q>0) then
update client set c_full_name = full_n where id_c = pr;
update client set c_mob_number = mobile where id_c = pr;
update consumption_details set id_d = idd where id_cod=idcod;
update consumption_details set c_quantity = q where id_cod=idcod;
update details set quantity = (quantity+q1) - q where named=name and idc=id_mm;
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for order_r
-- ----------------------------
DROP PROCEDURE IF EXISTS `order_r`;
delimiter ;;
CREATE PROCEDURE `order_r`(full_n varchar(55), car_b varchar(50), car_m varchar(70), mobile varchar(30), named varchar(50),q int)
begin
declare pr, pr1, idd,idc,idco,idcod, ide,a, pric_e int;
set idd=(select id_d from details join car_brand_model using (id_mm) join car_brand using (id_b)
join car_model using(id_m) where named=name and brand = car_b and model = car_m and quantity<>0);
set idc=(select id_mm from car_brand_model join car_brand using (id_b) join car_model using (id_m) where brand = car_b and model=car_m);
set idco = (select count(1) from consumption);
set idco = idco + 1;
set idcod = (select count(*) from consumption_details);
set idcod = idcod + 2;
set ide = (select id_em from employee where position='Автомеханік' limit 1);
set pr = (select count(1) from client);
set pr = pr + 1;
set a=(select quantity from details join car_brand_model using(id_mm) join car_brand using (id_b) join 
car_model using (id_m) where name = named and brand = car_b and model = car_m);
set pr1 = (select id_c from client where c_full_name = full_n);
if (a<>0 and a-q>0) then
if not exists(select c_full_name from client where c_full_name = full_n) then
update details set quantity = quantity - q where named=name and idc=id_mm;
insert into client values(pr, full_n, mobile);
insert into consumption values(idco, pr, now(), ide);
insert into consumption_details values(idcod, idco,idd, q);
else 
insert into consumption values(idco,pr1, now(), ide);
insert into consumption_details values(idcod, idco, idd, q);
update details set quantity = quantity - q where named=name and idc=id_mm;
end if;
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for price
-- ----------------------------
DROP PROCEDURE IF EXISTS `price`;
delimiter ;;
CREATE PROCEDURE `price`(named varchar(70), carm varchar(70))
begin
declare idd int;
declare pric_e int;
declare q int;
set idd=(select id_d from details where named=name and carm = car_mod and quantity<>0);
set q = q + (select c_quantity from consumption_details where idd=id_d);
set pric_e = (select price from supplies join details using(id_d) where q<>0);
select pric_e;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for purchase_details
-- ----------------------------
DROP PROCEDURE IF EXISTS `purchase_details`;
delimiter ;;
CREATE PROCEDURE `purchase_details`(monthh int)
begin
select id_d as Код, name as Назва, description as Опис, brand as Марка, model as Модель, date_supplies as ДатаПоставки, 
s_quantity as Кількість, price as ЦінаЗа1Од, price*s_quantity as ЗагЦіна from details join car_brand_model using (id_mm) 
join car_brand using (id_b) join car_model using (id_m)
join supplie_details using(id_d) join supplies using(id_del) where month(date_supplies) = monthh;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for registration
-- ----------------------------
DROP PROCEDURE IF EXISTS `registration`;
delimiter ;;
CREATE PROCEDURE `registration`(login varchar(55), pas varchar(75))
begin
declare id, idc int;
set id = (select count(*) from users);
set id = id + 1;
set idc = (SELECT id_c FROM client ORDER BY RAND() LIMIT 1);
insert into users values(id,idc,login,pas, 'user');
end
;;
delimiter ;

-- ----------------------------
-- Function structure for search_details_for_car
-- ----------------------------
DROP FUNCTION IF EXISTS `search_details_for_car`;
delimiter ;;
CREATE FUNCTION `search_details_for_car`(namee varchar(50), brand varchar(40), model varchar(40))
 RETURNS decimal(6,0)
  DETERMINISTIC
begin
return (select quantity from details join car_brand_model using(id_m) where namee=name and brand=car_brand and model=car_model );
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for search_details_for_car
-- ----------------------------
DROP PROCEDURE IF EXISTS `search_details_for_car`;
delimiter ;;
CREATE PROCEDURE `search_details_for_car`(namee varchar(50), brand varchar(40), model varchar(40))
begin
select namee, brand, model, price_d, quantity from details join car_brand_model using(id_m) where namee=name and brand=car_brand and model=car_model;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for supplie
-- ----------------------------
DROP PROCEDURE IF EXISTS `supplie`;
delimiter ;;
CREATE PROCEDURE `supplie`(full_n varchar(55), car_b varchar(50), car_m varchar(70), namee varchar(50), price int, sq int)
begin
declare idd, id_s,iddel, d, ide, iddd int;
declare s_name, s_full, s_carm, s_carb varchar(70);
set iddd=(select count(1) from supplie_details);
set iddd = iddd + 1; 
set iddel = (select count(1) from supplies);
set iddel = iddel + 1;
set ide = (select id_em from employee where position='Директор' or position = 'Фінансовий директор' limit 1);
set idd=(select id_d from details join car_brand_model using (id_mm) join car_brand using (id_b) join car_model using(id_m)
where name=namee and brand = car_b and model = car_m); -- айди детали
set id_s=(select id_sw from supply_workers where s_full_name=full_n); -- айди работника
set s_full = (select s_full_name from supply_workers where s_full_name = full_n); -- имя работника
set s_name = (select name from details join car_brand_model using (id_mm) join car_brand using(id_b) join car_model using(id_m)
where name = namee and brand = car_b and model = car_m); -- имя детали
set s_carb = (select brand from car_brand where brand=car_b); -- марка машины
set s_carm = (select model from car_model where model=car_m); -- модель машины
if(s_full = full_n and s_carb = car_b and s_carm = car_m and s_name = namee) then
insert into supplies values(iddel,id_s,now(),ide);
update details set quantity=quantity+sq where id_d = idd;
insert into supplie_details values(iddd,iddel,idd,price, sq);
call update_price (s_name,s_carb,s_carm);
end if;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for update_brand
-- ----------------------------
DROP PROCEDURE IF EXISTS `update_brand`;
delimiter ;;
CREATE PROCEDURE `update_brand`(car_b varchar(50), id_m int)
begin
declare i int;
set i = (select id_b from car_brand join car_brand_model using (id_b) where id_mm = id_m);
update car_brand set brand = car_b where id_b = i;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for update_model
-- ----------------------------
DROP PROCEDURE IF EXISTS `update_model`;
delimiter ;;
CREATE PROCEDURE `update_model`(car_m varchar(70), idm int)
begin
declare i int;
set i = (select id_m from car_model join car_brand_model using (id_m) where id_mm = idm);
update car_model set model = car_m where id_m = i;
end
;;
delimiter ;

-- ----------------------------
-- Procedure structure for update_price
-- ----------------------------
DROP PROCEDURE IF EXISTS `update_price`;
delimiter ;;
CREATE PROCEDURE `update_price`(name_e varchar(50), car_b varchar(50), car_m varchar(70))
begin
declare d float;
declare idd int;
set idd = (select id_d from details join car_brand_model using (id_mm) join car_brand using (id_b) 
join car_model using (id_m) where name=name_e and brand = car_b and model = car_m);
set d = (select ((Cast(sum(price*s_quantity) as Float)/Cast(sum(s_quantity) as float))*0.2)+
Cast(sum(price*s_quantity) as Float)/Cast(sum(s_quantity) as float) from supplie_details join details using (id_d) where id_d =idd);
update details set price_d = d where id_d = idd;
end
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
