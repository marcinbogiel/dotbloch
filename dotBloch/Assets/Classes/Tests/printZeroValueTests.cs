﻿using NUnit.Framework;

namespace Tests
{
    public class printZeroValue
    {
        Qubit quantumBit;
        // A Test behaves as an ordinary method
        [Test]
        public void nUnit_Test()
        {
            Assert.AreEqual(true, true);
            Assert.AreEqual(null, null);
        }

        [Test]
        public void theta_0_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            Assert.AreEqual("1", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_0_with_trailing_zeros_Test(){
            // no trailing zeroes when value is 0 or 1
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 0;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("1", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_5_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 5;
            Assert.AreEqual("0,999", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_37_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 37;
            Assert.AreEqual("0,948", quantumBit.print_zero_value());
        }        
        [Test]
        public void theta_43_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 43;
            Assert.AreEqual("0,93", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_43_with_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 43;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.930", quantumBit.print_zero_value(customSettings));
        }
        
        [Test]
        public void theta_87_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 87;
            Assert.AreEqual("0,725", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_97_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 97;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.663", quantumBit.print_zero_value(customSettings));
        }
        
        [Test]
        public void theta_127_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 127;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0.446", quantumBit.print_zero_value(customSettings));
        }
        
        [Test]
        public void theta_167_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 167;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0,113", quantumBit.print_zero_value(customSettings));
        }
        
        [Test]
        public void theta_179_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 179;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,false,3,PrintBlochSettings.DecimalSeparator.comma,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0,009", quantumBit.print_zero_value(customSettings));
        }
        
        [Test]
        public void theta_180_without_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            Assert.AreEqual("0", quantumBit.print_zero_value());
        }

        [Test]
        public void theta_180_with_trailing_zeros_Test(){
            quantumBit = new Qubit(0,0);
            quantumBit.thetaAngle = 180;
            PrintBlochSettings customSettings = new PrintBlochSettings(true,true,3,PrintBlochSettings.DecimalSeparator.dot,PrintBlochSettings.ImaginaryUnit.i);
            Assert.AreEqual("0", quantumBit.print_zero_value());
        }
    }
}
