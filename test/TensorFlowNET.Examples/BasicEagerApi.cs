﻿using System;
using System.Collections.Generic;
using System.Text;
using Tensorflow;

namespace TensorFlowNET.Examples
{
    /// <summary>
    /// Basic introduction to TensorFlow's Eager API.
    /// https://github.com/aymericdamien/TensorFlow-Examples/blob/master/examples/1_Introduction/basic_eager_api.py
    /// </summary>
    public class BasicEagerApi : IExample
    {
        public int Priority => 100;
        public bool Enabled => false;
        public string Name => "Basic Eager";

        private Tensor a, b, c, d;

        public bool Run()
        {
            // Set Eager API
            Console.WriteLine("Setting Eager mode...");
            tf.enable_eager_execution();

            // Define constant tensors
            Console.WriteLine("Define constant tensors");
            a = tf.constant(2);
            Console.WriteLine($"a = {a}");
            b = tf.constant(3);
            Console.WriteLine($"b = {b}");

            // Run the operation without the need for tf.Session
            Console.WriteLine("Running operations, without tf.Session");
            c = a + b;
            Console.WriteLine($"a + b = {c}");
            d = a * b;
            Console.WriteLine($"a * b = {d}");

            // Full compatibility with Numpy

            return true;
        }

        public void PrepareData()
        {
        }
    }
}
