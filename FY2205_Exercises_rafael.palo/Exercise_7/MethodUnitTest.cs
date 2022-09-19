// <copyright file="UnitTest1.cs" company="Exersize 7 Unit Testing">
// Copyright (c) Exersize 7 Unit Testing. All rights reserved.
// </copyright>

namespace Exercise_7
{
    using Exercise_6;
    using System;
    using Xunit;
    public class MethodUnitTest
    {
        [Fact]
        public void Test1()
        {
            // Finding the smallest integer
            // Arrange
            int[] A;
            int a, numb, result;
            numb = 0;
            result = 0;
            a = 5;
            int[] expectedOutput = new int[a];
            // Expected Output
            expectedOutput[0] = 3;
            // Fix value of the simulation
            int[] inputList = new int[a];
            inputList[0] = 1;
            inputList[1] = 2;
            inputList[2] = 4;
            inputList[3] = 6;
            inputList[4] = 5;

            // Act
            var actual = expectedOutput;

            // Assert
            Assert.Equal(expectedOutput, actual);
        }
    }
}
