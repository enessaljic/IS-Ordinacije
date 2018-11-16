-- phpMyAdmin SQL Dump
-- version 4.6.6deb4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 08, 2017 at 08:43 PM
-- Server version: 10.1.26-MariaDB-0+deb9u1
-- PHP Version: 7.0.19-1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mojDoktor`
--

-- --------------------------------------------------------

--
-- Table structure for table `Administratori`
--

CREATE TABLE `Administratori` (
  `id` int(11) NOT NULL,
  `ime` varchar(20) COLLATE utf8_bin NOT NULL,
  `prezime` varchar(20) COLLATE utf8_bin NOT NULL,
  `email` varchar(30) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `krvneGrupe`
--

CREATE TABLE `krvneGrupe` (
  `naziv` varchar(3) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `krvneGrupe`
--

INSERT INTO `krvneGrupe` (`naziv`) VALUES
('0+'),
('0-'),
('A+'),
('A-'),
('AB+'),
('AB-'),
('B+'),
('B-');

-- --------------------------------------------------------

--
-- Table structure for table `Lekari`
--

CREATE TABLE `Lekari` (
  `ime` varchar(15) COLLATE utf8_bin NOT NULL,
  `prezime` varchar(15) COLLATE utf8_bin NOT NULL,
  `jmbg` bigint(13) NOT NULL,
  `devojackoPrezime` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `datumRodjenja` date NOT NULL,
  `mestoRodjenja` varchar(20) COLLATE utf8_bin NOT NULL,
  `pol` char(2) COLLATE utf8_bin NOT NULL,
  `adresa` varchar(50) COLLATE utf8_bin NOT NULL,
  `mesto` varchar(20) COLLATE utf8_bin NOT NULL,
  `drzava` varchar(20) COLLATE utf8_bin NOT NULL,
  `telefon` varchar(15) COLLATE utf8_bin NOT NULL,
  `mobilniTelefon` varchar(15) COLLATE utf8_bin NOT NULL,
  `email` varchar(30) COLLATE utf8_bin NOT NULL,
  `idStruke` varchar(30) COLLATE utf8_bin NOT NULL,
  `opis` longtext COLLATE utf8_bin NOT NULL,
  `ocena` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `Pacijenti`
--

CREATE TABLE `Pacijenti` (
  `jmbg` bigint(13) NOT NULL,
  `ime` varchar(20) COLLATE utf8_bin NOT NULL,
  `prezime` varchar(20) COLLATE utf8_bin NOT NULL,
  `devojackoPrezime` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `datumRodjenja` date NOT NULL,
  `mestoRodjenja` varchar(20) COLLATE utf8_bin NOT NULL,
  `datumSmrti` date DEFAULT NULL,
  `pol` char(1) COLLATE utf8_bin NOT NULL,
  `adresaStanovanja` varchar(50) COLLATE utf8_bin NOT NULL,
  `mesto` varchar(50) COLLATE utf8_bin NOT NULL,
  `drzava` varchar(20) COLLATE utf8_bin NOT NULL,
  `brojTelefona` varchar(15) COLLATE utf8_bin NOT NULL,
  `brojMobTel` varchar(15) COLLATE utf8_bin NOT NULL,
  `email` varchar(30) COLLATE utf8_bin NOT NULL,
  `imeStaratelja` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `prezimeStaratelja` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `jmbgStaratelja` bigint(13) DEFAULT NULL,
  `adresaStaratelja` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `brTelefonaStaratelja` varchar(15) COLLATE utf8_bin DEFAULT NULL,
  `idKrvnaGrupa` varchar(3) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `podaziZaPrijavu`
--

CREATE TABLE `podaziZaPrijavu` (
  `id` int(11) NOT NULL,
  `idKorisnika` int(11) NOT NULL,
  `korisnickoIme` varchar(15) COLLATE utf8_bin NOT NULL,
  `lozinka` varchar(15) COLLATE utf8_bin NOT NULL,
  `tip` char(1) COLLATE utf8_bin NOT NULL,
  `aktivan` varchar(5) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `Posete`
--

CREATE TABLE `Posete` (
  `id` int(11) NOT NULL,
  `idLekara` bigint(13) NOT NULL,
  `anamnezija` longtext COLLATE utf8_bin NOT NULL,
  `objektivniPregled` longtext COLLATE utf8_bin NOT NULL,
  `idDijagnoze` int(11) NOT NULL,
  `idKontrole` int(11) DEFAULT NULL,
  `idRezultatiLaboratorije` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `rasporedPregleda`
--

CREATE TABLE `rasporedPregleda` (
  `id` int(11) NOT NULL,
  `datum` date NOT NULL,
  `vrijeme` time NOT NULL,
  `idStruka` varchar(30) COLLATE utf8_bin NOT NULL,
  `idLjekara` int(11) NOT NULL,
  `idPacijenta` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `rezultatiLaboratorije`
--

CREATE TABLE `rezultatiLaboratorije` (
  `id` int(11) NOT NULL,
  `idPacijenta` bigint(13) NOT NULL,
  `idLekara` bigint(13) NOT NULL,
  `tipTestiranja` varchar(15) COLLATE utf8_bin NOT NULL,
  `rezultat` varchar(500) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Table structure for table `struke`
--

CREATE TABLE `struke` (
  `struka` varchar(30) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `struke`
--

INSERT INTO `struke` (`struka`) VALUES
('Alergologija'),
('Biohemija'),
('Deramtologija'),
('Endokrinologija'),
('Ginekologija'),
('Hematologija'),
('Interna medicina'),
('Kardiologija'),
('Mikrobiologija'),
('Neurologija'),
('Radiologija'),
('Urologija');

-- --------------------------------------------------------

--
-- Table structure for table `zdravstveniKarton`
--

CREATE TABLE `zdravstveniKarton` (
  `idPacijenta` bigint(13) NOT NULL,
  `idPosete` int(11) NOT NULL,
  `datumiVreme` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Administratori`
--
ALTER TABLE `Administratori`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `krvneGrupe`
--
ALTER TABLE `krvneGrupe`
  ADD PRIMARY KEY (`naziv`);

--
-- Indexes for table `Lekari`
--
ALTER TABLE `Lekari`
  ADD PRIMARY KEY (`jmbg`),
  ADD KEY `idStruke` (`idStruke`);

--
-- Indexes for table `Pacijenti`
--
ALTER TABLE `Pacijenti`
  ADD PRIMARY KEY (`jmbg`),
  ADD KEY `idKrvnaGrupa` (`idKrvnaGrupa`);

--
-- Indexes for table `Posete`
--
ALTER TABLE `Posete`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idKontrole` (`idKontrole`),
  ADD KEY `idRezultatiPregleda` (`idRezultatiLaboratorije`),
  ADD KEY `idLekara` (`idLekara`);

--
-- Indexes for table `rasporedPregleda`
--
ALTER TABLE `rasporedPregleda`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idStruka` (`idStruka`),
  ADD KEY `idLjekara` (`idLjekara`),
  ADD KEY `idPacijenta` (`idPacijenta`);

--
-- Indexes for table `rezultatiLaboratorije`
--
ALTER TABLE `rezultatiLaboratorije`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idPacijenta` (`idPacijenta`),
  ADD KEY `idLekara` (`idLekara`);

--
-- Indexes for table `struke`
--
ALTER TABLE `struke`
  ADD PRIMARY KEY (`struka`);

--
-- Indexes for table `zdravstveniKarton`
--
ALTER TABLE `zdravstveniKarton`
  ADD KEY `idPacijenta` (`idPacijenta`),
  ADD KEY `idPosete` (`idPosete`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Administratori`
--
ALTER TABLE `Administratori`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `Posete`
--
ALTER TABLE `Posete`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rasporedPregleda`
--
ALTER TABLE `rasporedPregleda`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `rezultatiLaboratorije`
--
ALTER TABLE `rezultatiLaboratorije`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `Pacijenti`
--
ALTER TABLE `Pacijenti`
  ADD CONSTRAINT `Pacijenti_ibfk_1` FOREIGN KEY (`idKrvnaGrupa`) REFERENCES `krvneGrupe` (`naziv`);

--
-- Constraints for table `Posete`
--
ALTER TABLE `Posete`
  ADD CONSTRAINT `Posete_ibfk_1` FOREIGN KEY (`idLekara`) REFERENCES `Lekari` (`jmbg`),
  ADD CONSTRAINT `Posete_ibfk_2` FOREIGN KEY (`idKontrole`) REFERENCES `rasporedPregleda` (`id`),
  ADD CONSTRAINT `Posete_ibfk_3` FOREIGN KEY (`idRezultatiLaboratorije`) REFERENCES `rezultatiLaboratorije` (`id`);

--
-- Constraints for table `rasporedPregleda`
--
ALTER TABLE `rasporedPregleda`
  ADD CONSTRAINT `rasporedPregleda_ibfk_1` FOREIGN KEY (`idStruka`) REFERENCES `struke` (`struka`);

--
-- Constraints for table `rezultatiLaboratorije`
--
ALTER TABLE `rezultatiLaboratorije`
  ADD CONSTRAINT `rezultatiLaboratorije_ibfk_1` FOREIGN KEY (`idPacijenta`) REFERENCES `Pacijenti` (`jmbg`),
  ADD CONSTRAINT `rezultatiLaboratorije_ibfk_2` FOREIGN KEY (`idLekara`) REFERENCES `Lekari` (`jmbg`);

--
-- Constraints for table `zdravstveniKarton`
--
ALTER TABLE `zdravstveniKarton`
  ADD CONSTRAINT `zdravstveniKarton_ibfk_1` FOREIGN KEY (`idPacijenta`) REFERENCES `Pacijenti` (`jmbg`),
  ADD CONSTRAINT `zdravstveniKarton_ibfk_2` FOREIGN KEY (`idPosete`) REFERENCES `Posete` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
