-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 09, 2019 at 03:30 PM
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
-- Table structure for table `table_practice`
--

CREATE TABLE `table_practice` (
  `partPractice` smallint(6) NOT NULL,
  `numberPractice` smallint(6) NOT NULL,
  `linkPractice` text COLLATE utf8_persian_ci DEFAULT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `yearYearPracticeClass` char(5) COLLATE utf8_persian_ci NOT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `idUploader` char(10) COLLATE utf8_persian_ci DEFAULT NULL
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_professor`
--

CREATE TABLE `table_professor` (
  `idProfessor` char(10) COLLATE utf8_persian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_quiz`
--

CREATE TABLE `table_quiz` (
  `numberQuiz` smallint(6) NOT NULL,
  `dateQuiz` date DEFAULT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `yearYearPracticeClass` char(5) COLLATE utf8_persian_ci NOT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table_quizstudent`
--

CREATE TABLE `table_quizstudent` (
  `numberQuiz` smallint(6) NOT NULL,
  `idStudent` char(10) COLLATE utf8_persian_ci NOT NULL,
  `grade` smallint(6) DEFAULT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `yearYearPracticeClass` char(5) COLLATE utf8_persian_ci NOT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL
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
-- Table structure for table `table_studentpracticeclass`
--

CREATE TABLE `table_studentpracticeclass` (
  `grade` float DEFAULT NULL,
  `groupeNumberPracticeClass` smallint(6) NOT NULL,
  `termPracticeClass` bit(1) NOT NULL,
  `yearYearPracticeClass` char(5) COLLATE utf8_persian_ci NOT NULL,
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
-- Indexes for table `table_practice`
--
ALTER TABLE `table_practice`
  ADD PRIMARY KEY (`partPractice`,`numberPractice`,`termPracticeClass`,`yearYearPracticeClass`,`groupeNumberPracticeClass`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `yearYearPracticeClass` (`yearYearPracticeClass`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD PRIMARY KEY (`groupeNumberPracticeClass`,`termPracticeClass`,`yearYearPracticeClass`),
  ADD KEY `idProfessor` (`idProfessor`),
  ADD KEY `idTA` (`idTA`),
  ADD KEY `idCourse` (`idCourse`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `yearYearPracticeClass` (`yearYearPracticeClass`);

--
-- Indexes for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD PRIMARY KEY (`idProfessor`);

--
-- Indexes for table `table_quiz`
--
ALTER TABLE `table_quiz`
  ADD PRIMARY KEY (`numberQuiz`,`termPracticeClass`,`yearYearPracticeClass`,`groupeNumberPracticeClass`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `yearYearPracticeClass` (`yearYearPracticeClass`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

--
-- Indexes for table `table_quizstudent`
--
ALTER TABLE `table_quizstudent`
  ADD PRIMARY KEY (`numberQuiz`,`idStudent`,`termPracticeClass`,`yearYearPracticeClass`,`groupeNumberPracticeClass`),
  ADD KEY `idStudent` (`idStudent`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `yearYearPracticeClass` (`yearYearPracticeClass`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`);

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
-- Indexes for table `table_studentpracticeclass`
--
ALTER TABLE `table_studentpracticeclass`
  ADD PRIMARY KEY (`idStudent`,`termPracticeClass`,`yearYearPracticeClass`,`groupeNumberPracticeClass`),
  ADD KEY `groupeNumberPracticeClass` (`groupeNumberPracticeClass`),
  ADD KEY `termPracticeClass` (`termPracticeClass`),
  ADD KEY `yearYearPracticeClass` (`yearYearPracticeClass`);

--
-- Indexes for table `table_user`
--
ALTER TABLE `table_user`
  ADD PRIMARY KEY (`idUser`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `table_practice`
--
ALTER TABLE `table_practice`
  ADD CONSTRAINT `table_practice_ibfk_1` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`),
  ADD CONSTRAINT `table_practice_ibfk_2` FOREIGN KEY (`yearYearPracticeClass`) REFERENCES `table_practiceclass` (`yearYearPracticeClass`),
  ADD CONSTRAINT `table_practice_ibfk_3` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`);

--
-- Constraints for table `table_practiceclass`
--
ALTER TABLE `table_practiceclass`
  ADD CONSTRAINT `table_practiceclass_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practiceclass_ibfk_2` FOREIGN KEY (`idTA`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_practiceclass_ibfk_3` FOREIGN KEY (`idCourse`) REFERENCES `table_course` (`idCourse`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `table_professor`
--
ALTER TABLE `table_professor`
  ADD CONSTRAINT `table_professor_ibfk_1` FOREIGN KEY (`idProfessor`) REFERENCES `table_user` (`idUser`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `table_quiz`
--
ALTER TABLE `table_quiz`
  ADD CONSTRAINT `table_quiz_ibfk_1` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quiz_ibfk_2` FOREIGN KEY (`yearYearPracticeClass`) REFERENCES `table_practiceclass` (`yearYearPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quiz_ibfk_3` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `table_quizstudent`
--
ALTER TABLE `table_quizstudent`
  ADD CONSTRAINT `table_quizstudent_ibfk_1` FOREIGN KEY (`numberQuiz`) REFERENCES `table_quiz` (`numberQuiz`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_2` FOREIGN KEY (`idStudent`) REFERENCES `table_student` (`idStudent`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_3` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_quiz` (`termPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_4` FOREIGN KEY (`yearYearPracticeClass`) REFERENCES `table_quiz` (`yearYearPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_quizstudent_ibfk_5` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_quiz` (`groupeNumberPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE;

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

--
-- Constraints for table `table_studentpracticeclass`
--
ALTER TABLE `table_studentpracticeclass`
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_1` FOREIGN KEY (`groupeNumberPracticeClass`) REFERENCES `table_practiceclass` (`groupeNumberPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_2` FOREIGN KEY (`idStudent`) REFERENCES `table_student` (`idStudent`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_3` FOREIGN KEY (`termPracticeClass`) REFERENCES `table_practiceclass` (`termPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `table_studentpracticeclass_ibfk_4` FOREIGN KEY (`yearYearPracticeClass`) REFERENCES `table_practiceclass` (`yearYearPracticeClass`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
