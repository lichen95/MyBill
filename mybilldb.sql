/*
Navicat MySQL Data Transfer

Source Server         : MySql
Source Server Version : 50726
Source Host           : localhost:3306
Source Database       : mybilldb

Target Server Type    : MYSQL
Target Server Version : 50726
File Encoding         : 65001

Date: 2020-01-06 13:45:27
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for bills
-- ----------------------------
DROP TABLE IF EXISTS `bills`;
CREATE TABLE `bills` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `TypeId` int(11) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `CreateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `Desc` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for permissions
-- ----------------------------
DROP TABLE IF EXISTS `permissions`;
CREATE TABLE `permissions` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Desc` varchar(255) NOT NULL,
  `Area` varchar(255) NOT NULL,
  `Controller` varchar(255) NOT NULL,
  `Action` varchar(255) NOT NULL,
  `IsEnable` int(11) NOT NULL,
  `Group` varchar(255) NOT NULL,
  `CreateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UpdateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for rolepermissions
-- ----------------------------
DROP TABLE IF EXISTS `rolepermissions`;
CREATE TABLE `rolepermissions` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` int(11) NOT NULL,
  `PermissionId` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for roles
-- ----------------------------
DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Desc` varchar(255) NOT NULL,
  `Module` int(11) NOT NULL,
  `CreateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UpdateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `IsEnable` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for types
-- ----------------------------
DROP TABLE IF EXISTS `types`;
CREATE TABLE `types` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Desc` varchar(255) NOT NULL,
  `CreateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UpdateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `IsEnable` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for userroles
-- ----------------------------
DROP TABLE IF EXISTS `userroles`;
CREATE TABLE `userroles` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `RoleId` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `NickName` varchar(255) NOT NULL,
  `Mobile` varchar(255) NOT NULL,
  `Gender` int(11) NOT NULL,
  `CreateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `UpdateDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `LastLoginDate` datetime NOT NULL ON UPDATE CURRENT_TIMESTAMP,
  `IsEnable` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
SET FOREIGN_KEY_CHECKS=1;
