/*
 * DynamicProxy.NET
 * (C) Copyright 2003 Jeppe Cramon (jeppe@cramon.dk)
 * http://www.cramon.dk
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 * Disclaimer:
 * -----------
 * This software is provided "as is" without warranty of any kind,
 * either expressed or implied. The entire risk as to the
 * quality and performance of the software is with you. Should the
 * software prove defective, you assume the cost of all necessary
 * servicing, repair, or correction. In no event shall the author,
 * copyright holder, or any other party who may redistribute the
 * software be liable to you for damages, including any general,
 * special, incidental, or consequential damages arising out of
 * the use or inability to use the software (including, but not
 * limited to, loss of data, data being rendered inaccurate, loss of
 * business profits, loss of business information, business
 * interruptions, loss sustained by you or third parties, or a
 * failure of the software to operate with any other software) even
 * if the author, copyright holder, or other party has been advised
 * of the possibility of such damages. 
 * 
 */
using System;

namespace Simple.Tests.Lib.TestClasses
{
	/// <summary>
	/// Interface for the SimpleClass (since you have to program against interfaces with the Dynamic proxy)
	/// </summary>
	public interface ISimpleInterface {
		void Method1();
		string Method2();
		int Method3();
		int Method4(int inValue);
		void Method5(int inValue, out int outValue);
		void Method6(ref int value);
	}
}
