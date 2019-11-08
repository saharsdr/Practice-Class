-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 08, 2019 at 07:53 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_practiceclass`
--
CREATE DATABASE IF NOT EXISTS `database_practiceclass` DEFAULT CHARACTER SET utf8 COLLATE utf8_persian_ci;
USE `database_practiceclass`;

-- --------------------------------------------------------

--
-- Table structure for table `table_course`
--

CREATE TABLE `table_course` (
  `idCourse` char(7) COLLATE utf8_persian_ci NOT NULL,
  `nameCourse` varchar(20) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_practiceclass`
--

CREATE TABLE `table_practiceclass` (
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `yearYearPracticeClass` char(5) COLLATE utf8_persian_ci NOT NULL,
  `idCourse` char(7) COLLATE utf8_persian_ci DEFAULT NULL,
  `idProfessor` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `idTA` char(10) COLLATE utf8_persian_ci DEFAULT NULL
) ;

-- --------------------------------------------------------

--
-- Table structure for table `table_professor`
--

CREATE TABLE `table_professor` (
  `idProfessor` char(10) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_resource`
--

CREATE TABLE `table_resource` (
  `nameResource` char(50) COLLATE utf8_persian_ci NOT NULL,
  `linkResource` text COLLATE utf8_persian_ci DEFAULT NULL,
  `idCourse` char(7) COLLATE utf8_persian_ci NOT NULL,
  `idProfessor` char(10) COLLATE utf8_persian_ci DEFAULT NULL,
  `numberResource` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_student`
--

CREATE TABLE `table_student` (
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_user`
--

CREATE TABLE `table_user` (
  `idUser` char(10) COLLATE utf8_persian_ci NOT NULL,
  `firstNameUser` varchar(25) COLLATE utf8_persian_ci NOT NULL,
  `lastNameUser` varchar(25) COLLATE utf8_persian_ci NOT NULL,
  `password` varchar(30) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `table_course`
--
ALTER TABLE `table_course`
  ADD PRIMARY KEY (`idCourse`);

--
-- Indexes for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD PRIMARY KEY (`groupeNumberPracticeClass`,`termPracticeClass`,`yearYearPracticeClass`),
  ADD KEY `idProfessor` (`idProfessor`),
  ADD KEY `idTA` (`idTA`),
  ADD KEY `idCourse` (`idCourse`);

--
-- Indexes for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD PRIMARY KEY (`idProfessor`);

--
-- Indexes for table `table_resource`
--
ALTER TABLE `table_resource`
  ADD PRIMARY KEY (`idCourse`,`numberResource`),
  ADD KEY `table_resource_ibfk_1` (`idProfessor`);

--
-- Indexes for table `table_student`
--
ALTER TABLE `table_student`
  ADD PRIMARY KEY (`idStudent`);

--
-- Indexes for table `table_user`
--
ALTER TABLE `table_user`
  ADD PRIMARY KEY (`idUser`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD CONSTRAINT `table_practiceclass_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`),
  ADD CONSTRAINT `table_practiceclass_ibfk_2` FOREIGN KEY (`idTA`) REFERENCES `table_user` (`idUser`),
  ADD CONSTRAINT `table_practiceclass_ibfk_3` FOREIGN KEY (`idCourse`) REFERENCES `table_course` (`idCourse`);

--
-- Constraints for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD CONSTRAINT `table_professor_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `table_resource`
--
ALTER TABLE `table_resource`
  ADD CONSTRAINT `table_resource_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_resource_ibfk_2` FOREIGN KEY (`idCourse`) REFERENCES `table_course` (`idCourse`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `table_student`
--
ALTER TABLE `table_student`
  ADD CONSTRAINT `table_student_ibfk_1` FOREIGN KEY (`idStudent`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
