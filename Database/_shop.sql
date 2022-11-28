-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2022 at 03:21 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `#shop`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_product`
--

CREATE TABLE `add_product` (
  `pro_id` varchar(11) NOT NULL,
  `pro_category` varchar(250) NOT NULL,
  `pro_name` varchar(255) NOT NULL,
  `pro_image` varchar(1000) NOT NULL,
  `pro_video` varchar(255) NOT NULL,
  `pro_price` varchar(200) NOT NULL,
  `pro_discount` varchar(200) NOT NULL,
  `pro_description` varchar(255) NOT NULL,
  `pro_quantity` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `add_product`
--

INSERT INTO `add_product` (`pro_id`, `pro_category`, `pro_name`, `pro_image`, `pro_video`, `pro_price`, `pro_discount`, `pro_description`, `pro_quantity`) VALUES
('1011', 'Women', 'Sharee', 'sharee.jpg', 'Null', '2500', '10%', 'Comfortable', '1'),
('1012', 'Women', 'Kameez', 'Kameez.jpg', 'Null', '1500', '5%', 'Comfortable.', '1'),
('1013', 'Women', 'Kurti', 'Kurti.jpg', 'Null', '3000', '10%', 'Comfortable', '1'),
('2001', 'Men', 'Shirt', 'Shirt.jpg', 'Null', '550', '5%', 'Comfortable', '1'),
('2002', 'Men', 'Blazer', 'Suit.jpg', 'Null', '3500', '15%', 'Comfortable', '1'),
('2003', 'Men', 'Panjabi', 'panjabee.jpg', 'Null', '4500', '10%', 'Comfortable', '1'),
('302', 'Book', 'book', 'Amii-Misir-Ali-by-Humayun-Ahmed-185x278-1-1200x1803.jpg', 'null', '250', '15%', 'book', '1'),
('401', 'Shoe', 'Sneakers', 'shoe1.jpg', 'Null', '2500', '5%', 'Comfortable shoe for all size', '1'),
('4512', 'Shoe', 'Loafer', 'Loafer.jpg', 'Null', '4500', '5%', 'Comfortable', '1'),
('5001', 'Book', 'Misir Ali Shomogro', 'misir_ali_samagra-1-1.jpg', 'Null', '250', '5%', 'Nice book', '1'),
('5003', 'Book', 'Shuvro Shomogro', 'subhoo_somogro-1.jpg', 'Null', '450', '5%', 'Nice book ', '1'),
('540', 'Furniture', 'Almari', 'Almari.jpg', 'Null', '25000', '5%', 'nice', '1'),
('5400', 'Shoe', 'Shoe for men', 'shoe for men.jpg', 'Null', '2500', '5%', 'Comfortable', '1'),
('5411', 'Shoe', 'Shoe for women', 'Women shoe.jpg', 'Null', '3000', '5%', 'Comfortable', '1'),
('5640', 'Furniture', 'Chair', 'Chair.jpg', 'Null', '3500', '5%', 'Comfortable', '1'),
('5642', 'Furniture', 'Sofa', 'Sofa.jpg', 'Null', '65000', '5%', 'COmfortable', '1'),
('852', 'Bag', 'School Bag', 'Men bag.jpg', 'Null', '1500', '5%', 'Comfortable', '1'),
('983', 'Bag', 'Bag', 'Bag1.jpg', 'Null', '2500', '5%', 'Comfortable', '1'),
('985', 'Bag', 'Ladies Bag', 'Bag.jpg', 'Null', '1000', '5%', 'fashion', '1');

-- --------------------------------------------------------

--
-- Table structure for table `admin_login`
--

CREATE TABLE `admin_login` (
  `id` int(11) NOT NULL,
  `name` varchar(250) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin_login`
--

INSERT INTO `admin_login` (`id`, `name`, `password`) VALUES
(1, 's', 's'),
(4554, 'nahida zaman bina', 'asdfadsf'),
(12211, 'sabbir rahman', 'sdf5455'),
(25454, 'sahenul islam', '56531234'),
(56456, 'karim khan', 'sdf54dsf');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `user_id` int(11) DEFAULT NULL,
  `product_id` varchar(11) DEFAULT NULL,
  `product_name` varchar(500) NOT NULL,
  `quantity` int(10) DEFAULT NULL,
  `price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`user_id`, `product_id`, `product_name`, `quantity`, `price`) VALUES
(1, '1012', 'Kameez', 10, 100),
(3, '1011', 'Sharee', 1, 2500);

-- --------------------------------------------------------

--
-- Table structure for table `product_buy`
--

CREATE TABLE `product_buy` (
  `sell_id` int(11) NOT NULL,
  `user_name` varchar(250) NOT NULL,
  `pro_id` varchar(250) NOT NULL,
  `user_phone` varchar(250) NOT NULL,
  `address` varchar(255) NOT NULL,
  `delivery` varchar(200) NOT NULL,
  `pro_price` varchar(200) NOT NULL,
  `pro_name` varchar(255) NOT NULL,
  `pro_category` varchar(250) NOT NULL,
  `pro_quantity` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_buy`
--

INSERT INTO `product_buy` (`sell_id`, `user_name`, `pro_id`, `user_phone`, `address`, `delivery`, `pro_price`, `pro_name`, `pro_category`, `pro_quantity`) VALUES
(62, 'nahida', '1011', '01645124512', '180/3 rode 5 , Mirpur - 10', 'Cash on Delivary', '2500', 'Sharee', 'Women', 'Comfortable'),
(63, 'nahida', '1013', '01645124512', '180/3 rode 5 , Mirpur - 10', 'Nagad', '3000', 'Kurti', 'Women', 'Comfortable'),
(64, 'nahida', '302', '01645124512', '180/3 rode 5 , Mirpur - 10', 'Cash on Delivary', '250', 'book', 'Book', 'book'),
(65, 'nahida', '401', '01645124512', '180/3 rode 5 , Mirpur - 10', 'Master Card', '2500', 'Sneakers', 'Shoe', 'Comfortable shoe for all size'),
(66, 'karim khan', '540', '018655552344', '342/B, mirpur 1', 'Rocket', '25000', 'Almari', 'Furniture', 'nice'),
(67, 'karim khan', '5640', '01565453334', '180/3 rode 5 , Mirpur - 11', 'Cash on Delivary', '3500', 'Chair', 'Furniture', 'Comfortable'),
(68, 'sahenul', '2001', '01766323339', 'lake view road middle paikpara mirpur-1', 'Cash on Delivary', '550', 'Shirt', 'Men', 'Comfortable'),
(69, 'sahenul', '5400', '01952322244', 'kallanpur notun bazar, mirpur-1', 'Nagad', '2500', 'Shoe for men', 'Shoe', 'Comfortable'),
(70, 'sahenul', '2001', '', '', 'Master Card', '550', 'Shirt', 'Men', 'Comfortable'),
(71, 'sa', '1011', '01234567', 'mirpur', 'Cash on Delivary', '2500', 'Sharee', 'Women', 'Comfortable');

-- --------------------------------------------------------

--
-- Table structure for table `user_login`
--

CREATE TABLE `user_login` (
  `id` int(11) NOT NULL,
  `user_name` varchar(250) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_login`
--

INSERT INTO `user_login` (`id`, `user_name`, `email`, `password`) VALUES
(1, 'nahida', 'nahida@gmail.com', '1234'),
(2, 'sahenul', 'sahenul@gmail.com', 'sdf'),
(3, 'sa', 'sa@gmail.com', '12'),
(4, 's', 's125@gmail.com', 's452323'),
(5, 'karim khan', 'karimKhan@gmail.com', 's');

-- --------------------------------------------------------

--
-- Table structure for table `user_msg`
--

CREATE TABLE `user_msg` (
  `Id` int(11) NOT NULL,
  `name` varchar(250) NOT NULL,
  `email` varchar(255) NOT NULL,
  `massage` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_msg`
--

INSERT INTO `user_msg` (`Id`, `name`, `email`, `massage`) VALUES
(1, 'bina', 'bina@gmail.com', 'hiiiiiiiiiii'),
(2, 'kdk', 'skldj@gkajkl', 'sdjfj'),
(3, 's', 's@gamil.com', 'sagasdfsadfsdfd'),
(4, 's', 's@gmail.com', 'sdf'),
(5, 'sahenul', 'sahenul@gmail.com', 'I want to know payment system of your shop. please explain;');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `add_product`
--
ALTER TABLE `add_product`
  ADD PRIMARY KEY (`pro_id`);

--
-- Indexes for table `admin_login`
--
ALTER TABLE `admin_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `product_buy`
--
ALTER TABLE `product_buy`
  ADD PRIMARY KEY (`sell_id`);

--
-- Indexes for table `user_login`
--
ALTER TABLE `user_login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user_msg`
--
ALTER TABLE `user_msg`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `product_buy`
--
ALTER TABLE `product_buy`
  MODIFY `sell_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT for table `user_login`
--
ALTER TABLE `user_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user_msg`
--
ALTER TABLE `user_msg`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cart`
--
ALTER TABLE `cart`
  ADD CONSTRAINT `cart_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user_login` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
