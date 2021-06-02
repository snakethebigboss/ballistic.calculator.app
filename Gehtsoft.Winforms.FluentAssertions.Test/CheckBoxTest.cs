﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using FluentAssertions;
using Xunit.Sdk;

namespace Gehtsoft.Winforms.FluentAssertions.Test
{
    public class CheckBoxTest
    {
        [Fact]
        public void Checked_OK()
        {
            using var tf = new TestForm();
            var c = tf.AddControl<CheckBox>(1, 1, 5, 5);
            c.Checked = true;
            ((Action)(() => c.Should().BeChecked())).Should().NotThrow();
        }

        [Fact]
        public void Checked_Failed()
        {
            using var tf = new TestForm();
            var c = tf.AddControl<CheckBox>(1, 1, 5, 5);
            c.Checked = false;
            ((Action)(() => c.Should().BeChecked())).Should().Throw<XunitException>();
        }
        [Fact]
        public void NotChecked_OK()
        {
            using var tf = new TestForm();
            var c = tf.AddControl<CheckBox>(1, 1, 5, 5);
            c.Checked = false;
            ((Action)(() => c.Should().BeNotChecked())).Should().NotThrow();
        }

        [Fact]
        public void NotChecked_Failed()
        {
            using var tf = new TestForm();
            var c = tf.AddControl<CheckBox>(1, 1, 5, 5);
            c.Checked = true;
            ((Action)(() => c.Should().BeNotChecked())).Should().Throw<XunitException>();
        }
    }
}
