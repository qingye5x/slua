﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UIButtonScale : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		UIButtonScale o;
		o=new UIButtonScale();
		pushObject(l,o);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tweenTarget(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		pushValue(l,o.tweenTarget);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_tweenTarget(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		UnityEngine.Transform v;
		checkType(l,2,out v);
		o.tweenTarget=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hover(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		pushValue(l,o.hover);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hover(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.hover=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressed(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		pushValue(l,o.pressed);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressed(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		UnityEngine.Vector3 v;
		checkType(l,2,out v);
		o.pressed=v;
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_duration(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		pushValue(l,o.duration);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_duration(IntPtr l) {
		UIButtonScale o = (UIButtonScale)checkSelf(l);
		System.Single v;
		checkType(l,2,out v);
		o.duration=v;
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UIButtonScale");
		addMember(l,"tweenTarget",get_tweenTarget,set_tweenTarget,true);
		addMember(l,"hover",get_hover,set_hover,true);
		addMember(l,"pressed",get_pressed,set_pressed,true);
		addMember(l,"duration",get_duration,set_duration,true);
		createTypeMetatable(l,constructor, typeof(UIButtonScale),typeof(UnityEngine.MonoBehaviour));
	}
}