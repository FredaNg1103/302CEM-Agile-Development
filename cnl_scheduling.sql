-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 24, 2018 at 04:17 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cnl_scheduling`
--

-- --------------------------------------------------------

--
-- Table structure for table `classroom`
--

DROP TABLE IF EXISTS `classroom`;
CREATE TABLE IF NOT EXISTS `classroom` (
  `classroom_id` int(255) NOT NULL AUTO_INCREMENT,
  `classroom_name` varchar(255) NOT NULL,
  `classroom_capacity` int(4) NOT NULL,
  `classroom_type` int(1) NOT NULL,
  PRIMARY KEY (`classroom_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom`
--

INSERT INTO `classroom` (`classroom_id`, `classroom_name`, `classroom_capacity`, `classroom_type`) VALUES
(1, '101', 20, 1),
(2, '102', 30, 1),
(3, '103', 40, 1),
(4, '201', 20, 2),
(5, '202', 30, 2),
(6, '203', 40, 2),
(7, '301', 20, 2),
(8, '302', 30, 2),
(9, '303', 40, 2);

-- --------------------------------------------------------

--
-- Table structure for table `classroom_utility`
--

DROP TABLE IF EXISTS `classroom_utility`;
CREATE TABLE IF NOT EXISTS `classroom_utility` (
  `cls_uty_id` int(255) NOT NULL AUTO_INCREMENT,
  `classroom_id` int(255) NOT NULL,
  `utility_id` int(255) NOT NULL,
  PRIMARY KEY (`cls_uty_id`),
  KEY `fk_classroom_id` (`classroom_id`) USING BTREE,
  KEY `fk_utility_id` (`utility_id`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `classroom_utility`
--

INSERT INTO `classroom_utility` (`cls_uty_id`, `classroom_id`, `utility_id`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(5, 4, 2),
(7, 5, 2),
(9, 6, 2),
(11, 7, 3),
(13, 8, 3),
(15, 9, 3);

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
CREATE TABLE IF NOT EXISTS `course` (
  `course_id` int(255) NOT NULL AUTO_INCREMENT,
  `school_id` int(255) NOT NULL,
  `course_name` varchar(255) NOT NULL,
  PRIMARY KEY (`course_id`),
  KEY `fk_school_id` (`school_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `school_id`, `course_name`) VALUES
(1, 1, '1001-Business'),
(2, 1, '1002-Computer Science'),
(3, 1, '1003-Electrical Engineering');

-- --------------------------------------------------------

--
-- Table structure for table `course_utility`
--

DROP TABLE IF EXISTS `course_utility`;
CREATE TABLE IF NOT EXISTS `course_utility` (
  `crs_uty_id` int(255) NOT NULL AUTO_INCREMENT,
  `course_id` int(255) NOT NULL,
  `utility_id` int(255) NOT NULL,
  PRIMARY KEY (`crs_uty_id`),
  KEY `fk_course_id` (`course_id`),
  KEY `fk_utility_id` (`utility_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course_utility`
--

INSERT INTO `course_utility` (`crs_uty_id`, `course_id`, `utility_id`) VALUES
(1, 1, 1),
(3, 2, 2),
(5, 3, 3);

-- --------------------------------------------------------

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
CREATE TABLE IF NOT EXISTS `schedule` (
  `schedule_id` int(255) NOT NULL AUTO_INCREMENT,
  `classroom_id` int(255) NOT NULL,
  `course_id` int(255) NOT NULL,
  `user_id` int(255) NOT NULL,
  `schedule_datetime_start` datetime NOT NULL,
  `schedule_datetime_end` datetime NOT NULL,
  PRIMARY KEY (`schedule_id`),
  KEY `fk_classroom_id` (`classroom_id`),
  KEY `fk_course_id` (`course_id`),
  KEY `fk_user_id` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schedule`
--

INSERT INTO `schedule` (`schedule_id`, `classroom_id`, `course_id`, `user_id`, `schedule_datetime_start`, `schedule_datetime_end`) VALUES
(1, 1, 1, 2, '2018-02-22 08:00:00', '2018-02-22 10:00:00'),
(2, 4, 2, 2, '2018-02-23 08:00:00', '2018-02-23 10:00:00'),
(3, 8, 3, 2, '2018-03-05 10:00:00', '2018-03-05 12:00:00'),
(4, 4, 2, 2, '2018-03-12 14:00:00', '2018-03-12 16:00:00'),
(5, 6, 2, 2, '2018-03-26 08:00:00', '2018-03-26 12:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `school`
--

DROP TABLE IF EXISTS `school`;
CREATE TABLE IF NOT EXISTS `school` (
  `school_id` int(255) NOT NULL AUTO_INCREMENT,
  `school_name` varchar(255) NOT NULL,
  PRIMARY KEY (`school_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `school`
--

INSERT INTO `school` (`school_id`, `school_name`) VALUES
(1, 'Inti International College');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int(255) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(255) NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `user_role` int(2) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `user_name`, `user_password`, `user_role`) VALUES
(1, 'admin', 'admin', 1),
(2, 'lecturer1', 'lecturer1', 2);

-- --------------------------------------------------------

--
-- Table structure for table `utility`
--

DROP TABLE IF EXISTS `utility`;
CREATE TABLE IF NOT EXISTS `utility` (
  `utility_id` int(11) NOT NULL AUTO_INCREMENT,
  `utility_name` varchar(255) NOT NULL,
  PRIMARY KEY (`utility_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `utility`
--

INSERT INTO `utility` (`utility_id`, `utility_name`) VALUES
(1, 'Projector'),
(2, 'Computer'),
(3, 'Electrical engineering tools'),
(4, 'Other');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `classroom_utility`
--
ALTER TABLE `classroom_utility`
  ADD CONSTRAINT `fk_classroom_id` FOREIGN KEY (`classroom_id`) REFERENCES `classroom` (`classroom_id`),
  ADD CONSTRAINT `fk_utility_id` FOREIGN KEY (`utility_id`) REFERENCES `utility` (`utility_id`);

--
-- Constraints for table `course`
--
ALTER TABLE `course`
  ADD CONSTRAINT `fk_school_id` FOREIGN KEY (`school_id`) REFERENCES `school` (`school_id`);

--
-- Constraints for table `course_utility`
--
ALTER TABLE `course_utility`
  ADD CONSTRAINT `fk_course_id` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  ADD CONSTRAINT `fk_utilitys_id` FOREIGN KEY (`utility_id`) REFERENCES `utility` (`utility_id`);

--
-- Constraints for table `schedule`
--
ALTER TABLE `schedule`
  ADD CONSTRAINT `fk_classrooms_id` FOREIGN KEY (`classroom_id`) REFERENCES `classroom` (`classroom_id`),
  ADD CONSTRAINT `fk_courses_id` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`),
  ADD CONSTRAINT `fk_users_id` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
