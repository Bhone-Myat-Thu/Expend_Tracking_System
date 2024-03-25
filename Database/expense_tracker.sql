-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 16, 2023 at 04:40 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `expense_tracker`
--
CREATE DATABASE IF NOT EXISTS `expense_tracker` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `expense_tracker`;

-- --------------------------------------------------------

--
-- Table structure for table `expense`
--

CREATE TABLE `expense` (
  `userid` int(11) DEFAULT NULL,
  `expid` int(11) NOT NULL,
  `month` varchar(255) DEFAULT NULL,
  `payment` varchar(255) DEFAULT NULL,
  `cost` int(11) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `category` varchar(14) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `expense`
--

INSERT INTO `expense` (`userid`, `expid`, `month`, `payment`, `cost`, `description`, `category`) VALUES
(1, 1, 'Jan', 'Cash', 100, 'This is first payment', 'Education'),
(1, 2, 'Jan', 'Cash', 200, 'This is first payment', 'Saving'),
(1, 3, 'Jan', 'Cash', 150, 'This is first payment', 'Health'),
(1, 4, 'Jan', 'Cash', 50, 'This is first payment', 'Transporation'),
(1, 5, 'Feb', 'Cash', 130, 'This is feb payment', 'Education'),
(1, 6, 'Feb', 'Cash', 210, 'This is feb payment', 'Saving'),
(1, 7, 'Feb', 'Cash', 290, 'This is feb payment', 'Health'),
(1, 8, 'Feb', 'Cash', 150, 'This is feb payment', 'Transporation'),
(1, 9, 'Mar', 'Cash', 100, 'This is march payment', 'Education'),
(1, 10, 'Mar', 'Cash', 250, 'This is march payment', 'Saving'),
(1, 11, 'Mar', 'Cash', 380, 'This is march payment', 'Health'),
(1, 12, 'Mar', 'Cash', 59, 'This is march payment', 'Transporation'),
(1, 13, 'Apr', 'Cash', 180, 'This is april payment', 'Education'),
(1, 14, 'Apr', 'Cash', 200, 'This is april payment', 'Saving'),
(1, 15, 'Apr', 'Cash', 100, 'This is april payment', 'Health'),
(1, 16, 'Apr', 'Cash', 20, 'This is april payment', 'Transporation'),
(1, 17, 'May', 'Cash', 200, 'This is may payment', 'Education'),
(1, 18, 'May', 'Cash', 100, 'This is may payment', 'Saving'),
(1, 19, 'May', 'Cash', 100, 'This is may payment', 'Health'),
(1, 20, 'May', 'Cash', 150, 'This is may payment', 'Transporation'),
(1, 21, 'Jun', 'Cash', 100, 'This is june payment', 'Education'),
(1, 22, 'Jun', 'Cash', 200, 'This is june payment', 'Saving'),
(1, 23, 'Jun', 'Cash', 300, 'This is june payment', 'Health'),
(1, 24, 'Jun', 'Cash', 50, 'This is june payment', 'Transporation'),
(1, 25, 'Jul', 'Cash', 100, 'This is july payment', 'Education'),
(1, 26, 'Jul', 'Cash', 200, 'This is july payment', 'Saving'),
(1, 27, 'Jul', 'Cash', 300, 'This is july payment', 'Health'),
(1, 28, 'Jul', 'Cash', 50, 'This is july payment', 'Transporation'),
(1, 29, 'Aug', 'Cash', 100, 'This is august payment', 'Education'),
(1, 30, 'Aug', 'Cash', 200, 'This is august payment', 'Saving'),
(1, 31, 'Aug', 'Cash', 300, 'This is august payment', 'Health'),
(1, 32, 'Aug', 'Cash', 50, 'This is august payment', 'Transporation'),
(1, 33, 'Sep', 'Cash', 100, 'This is september payment', 'Education'),
(1, 34, 'Sep', 'Cash', 200, 'This is september payment', 'Saving'),
(1, 35, 'Sep', 'Cash', 300, 'This is september payment', 'Health'),
(1, 36, 'Sep', 'Cash', 50, 'This is september payment', 'Transporation'),
(1, 37, 'Oct', 'Cash', 100, 'This is october payment', 'Education'),
(1, 38, 'Oct', 'Cash', 200, 'This is october payment', 'Saving'),
(1, 39, 'Oct', 'Cash', 300, 'This is october payment', 'Health'),
(1, 40, 'Oct', 'Cash', 50, 'This is october payment', 'Transporation'),
(1, 41, 'Nov', 'Cash', 100, 'This is november payment', 'Education'),
(1, 42, 'Nov', 'Cash', 200, 'This is november payment', 'Saving'),
(1, 43, 'Nov', 'Cash', 300, 'This is november payment', 'Health'),
(1, 44, 'Nov', 'Cash', 50, 'This is november payment', 'Transporation'),
(1, 45, 'Dec', 'Cash', 100, 'This is december payment', 'Education'),
(1, 46, 'Dec', 'Cash', 200, 'This is december payment', 'Saving'),
(1, 47, 'Dec', 'Cash', 300, 'This is december payment', 'Health'),
(1, 48, 'Dec', 'Cash', 50, 'This is december payment', 'Transporation'),
(1, 49, 'Oct', 'Credit Card', 80, 'This is second payment', 'Health'),
(1, 50, 'Dec', 'Cash', 50, 'This is third payment', 'Transporation'),
(1, 51, 'Mar', 'Debit Card', 100, 'This is fourth payment', 'Health');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userid` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userid`, `username`, `password`) VALUES
(1, 'johndoe', 'Password123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `expense`
--
ALTER TABLE `expense`
  ADD PRIMARY KEY (`expid`),
  ADD KEY `userid` (`userid`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `expense`
--
ALTER TABLE `expense`
  MODIFY `expid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `expense`
--
ALTER TABLE `expense`
  ADD CONSTRAINT `expense_ibfk_1` FOREIGN KEY (`userid`) REFERENCES `users` (`userid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
