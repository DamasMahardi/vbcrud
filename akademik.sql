-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 09, 2019 at 12:45 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `akademik`
--

-- --------------------------------------------------------

--
-- Table structure for table `mtkuliah`
--

CREATE TABLE `mtkuliah` (
  `kdmk` varchar(5) NOT NULL,
  `nama_mk` varchar(30) DEFAULT NULL,
  `sks` int(12) DEFAULT NULL,
  `smst` int(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mtkuliah`
--

INSERT INTO `mtkuliah` (`kdmk`, `nama_mk`, `sks`, `smst`) VALUES
('A1', 'Basis Data', 2, 3),
('A2', 'Algoritma dan Pemograman', 3, 1),
('A3', 'Data Mining', 3, 7);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `mtkuliah`
--
ALTER TABLE `mtkuliah`
  ADD PRIMARY KEY (`kdmk`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
