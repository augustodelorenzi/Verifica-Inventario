-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Creato il: Gen 29, 2024 alle 11:48
-- Versione del server: 10.4.22-MariaDB
-- Versione PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventario`
--

-- --------------------------------------------------------

--
-- Struttura della tabella `articoli`
--

CREATE TABLE `articoli` (
  `CodiceFarnell` int(7) NOT NULL,
  `Descrizione` varchar(60) NOT NULL,
  `Produttore` varchar(15) NOT NULL,
  `CodiceProduttore` varchar(20) NOT NULL,
  `Quantita` int(3) NOT NULL,
  `PrezzoUnitario` decimal(30,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dump dei dati per la tabella `articoli`
--

INSERT INTO `articoli` (`CodiceFarnell`, `Descrizione`, `Produttore`, `CodiceProduttore`, `Quantita`, `PrezzoUnitario`) VALUES
(1123696, 'INTERR., A 2 POLI, 6 POS, 0,15A, 250V; n\' Di Posizioni Inter', 'LORLIN', 'CK1050', 50, '1.97'),
(1716993, 'TERMINAL BLOCK, WIRE TO BRD, 2POS, 16AWG; CTB1202 S', 'CAMDENBOSS', 'CTB1202/2BK', 100, '0.22'),
(1716996, 'TERMINAL BLOCK, WIRE TO BRD, 5POS, 16AWG CTB1202 S', 'CAMDENBOSS', 'CTB1202/5BK', 20, '0.72'),
(2346522, 'CON. 1000µF, 35V, 20%; Capacità:1000µF; 35V;S PK', 'RUBYCON', '35PK1000MEFCT810X20', 50, '0.41'),
(2627992, 'REGOL. TENS. LIN. FISSA, 15V, 1A, TO-220;', 'ON SEMICONDUCT', 'NCP7815TG', 50, '0.49'),
(2668407, 'PRESA DIP, 8POS, 2FILE, 2.54MM, TH; No.', 'AMPHENOL FCI', 'DILB8P-223TLF', 100, '0.13'),
(2907957, 'USB CABLE, 2.0 PLUG A-MICRO B, 6FT, BLK; Da Connettore a Con', 'MULTICOMP', 'MC002734', 50, '1.29'),
(3117069, 'IC, OP AMP, DUAL, 0.3V/US, 3000UV, PDIP8', 'TEXAS INSTR.', 'LM358AP', 100, '0.24'),
(4148009, 'CLORURO FERRICO, 36C, 2.5L TANICA;', 'CIF', 'AR412', 5, '23.09'),
(4208547, 'RIVELATORE; Tipo di Sviluppatore, Sviluppatore Positivo; Sos', 'CIF', 'AR45', 10, '2.73');

--
-- Indici per le tabelle scaricate
--

--
-- Indici per le tabelle `articoli`
--
ALTER TABLE `articoli`
  ADD PRIMARY KEY (`CodiceFarnell`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
