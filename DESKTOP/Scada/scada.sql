-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 22, 2020 at 02:37 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `scada`
--

-- --------------------------------------------------------

--
-- Table structure for table `niv`
--

CREATE TABLE `niv` (
  `id` int(11) NOT NULL,
  `niveau` float NOT NULL,
  `time_date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `niv`
--

INSERT INTO `niv` (`id`, `niveau`, `time_date`) VALUES
(1, 3, '2020-06-09 01:00:00'),
(2, 3.2, '2020-06-09 01:30:00'),
(3, 2.98, '2020-06-09 01:05:05'),
(4, 2.75, '2020-06-09 04:30:00'),
(5, 2.5, '2020-06-09 02:00:00'),
(6, 2.3, '2020-06-09 02:30:00'),
(7, 2.45, '2020-06-01 03:00:00'),
(8, 2.6, '2020-06-21 03:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `pump`
--

CREATE TABLE `pump` (
  `id` int(11) NOT NULL,
  `etat_bh_gra` tinyint(1) NOT NULL,
  `etat_bahrori-petit` tinyint(1) NOT NULL,
  `etat_HD1` tinyint(1) NOT NULL,
  `etat_HD2` tinyint(1) NOT NULL,
  `etat_HD3` tinyint(1) NOT NULL,
  `situ_bh_gra` varchar(50) NOT NULL,
  `situ_bahrori-petit` varchar(50) NOT NULL,
  `situ_HD1` varchar(50) NOT NULL,
  `situ_HD2` varchar(50) NOT NULL,
  `situ_HD3` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pump`
--

INSERT INTO `pump` (`id`, `etat_bh_gra`, `etat_bahrori-petit`, `etat_HD1`, `etat_HD2`, `etat_HD3`, `situ_bh_gra`, `situ_bahrori-petit`, `situ_HD1`, `situ_HD2`, `situ_HD3`) VALUES
(1, 1, 1, 1, 1, 1, 'auto', 'auto', 'auto', 'auto', 'auto'),
(2, 1, 1, 1, 1, 1, 'auto', 'auto', 'auto', 'auto', 'auto');

-- --------------------------------------------------------

--
-- Table structure for table `reservoir_etat`
--

CREATE TABLE `reservoir_etat` (
  `def_alim` tinyint(1) NOT NULL,
  `def_trans` tinyint(1) NOT NULL,
  `def_pump_bh_g` tinyint(1) NOT NULL,
  `def_pump_bh_petit` tinyint(1) NOT NULL,
  `def_pump_HD1` tinyint(1) NOT NULL,
  `def_pump__HD2` tinyint(1) NOT NULL,
  `def_pump_HD3` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `valeur`
--

CREATE TABLE `valeur` (
  `compteur_so300` int(11) NOT NULL,
  `compteur_sor500` int(11) NOT NULL,
  `date` date NOT NULL,
  `compteur_ent` int(11) NOT NULL,
  `debit_ent` int(11) NOT NULL,
  `compteur_elec` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `valeur`
--

INSERT INTO `valeur` (`compteur_so300`, `compteur_sor500`, `date`, `compteur_ent`, `debit_ent`, `compteur_elec`, `id`) VALUES
(100, 200, '2020-06-15', 300, 45, 400, 1),
(200, 300, '2020-06-16', 400, 45, 500, 2),
(300, 400, '2020-06-15', 500, 45, 600, 3),
(400, 500, '2020-06-16', 600, 45, 700, 4),
(500, 600, '2020-06-16', 700, 800, 900, 6);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `niv`
--
ALTER TABLE `niv`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pump`
--
ALTER TABLE `pump`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `valeur`
--
ALTER TABLE `valeur`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `niv`
--
ALTER TABLE `niv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `pump`
--
ALTER TABLE `pump`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `valeur`
--
ALTER TABLE `valeur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
