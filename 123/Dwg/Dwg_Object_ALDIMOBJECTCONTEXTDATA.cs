//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_ALDIMOBJECTCONTEXTDATA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_ALDIMOBJECTCONTEXTDATA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_ALDIMOBJECTCONTEXTDATA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_ALDIMOBJECTCONTEXTDATA() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Object_ALDIMOBJECTCONTEXTDATA(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_class_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_default {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_is_default_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_is_default_get(swigCPtr);
      return ret;
    } 
  }

  public byte in_dwg {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_in_dwg_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_in_dwg_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref scale {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_scale_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_scale_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_name_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD def_pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_def_pt_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_def_pt_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public byte b293 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b293_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b293_get(swigCPtr);
      return ret;
    } 
  }

  public byte b294 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b294_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b294_get(swigCPtr);
      return ret;
    } 
  }

  public double bd140 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_bd140_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_bd140_get(swigCPtr);
      return ret;
    } 
  }

  public byte b298 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b298_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b298_get(swigCPtr);
      return ret;
    } 
  }

  public byte b291 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b291_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b291_get(swigCPtr);
      return ret;
    } 
  }

  public ushort flag {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_flag_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_flag_get(swigCPtr);
      return ret;
    } 
  }

  public byte b292 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b292_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b292_get(swigCPtr);
      return ret;
    } 
  }

  public ushort bs71 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_bs71_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_bs71_get(swigCPtr);
      return ret;
    } 
  }

  public byte b280 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b280_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b280_get(swigCPtr);
      return ret;
    } 
  }

  public byte b295 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b295_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b295_get(swigCPtr);
      return ret;
    } 
  }

  public byte b296 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b296_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b296_get(swigCPtr);
      return ret;
    } 
  }

  public byte b297 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b297_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA_b297_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD _11pt {
    set {
      LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA__11pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ALDIMOBJECTCONTEXTDATA__11pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_ALDIMOBJECTCONTEXTDATA() : this(LibreDWGPINVOKE.new_Dwg_Object_ALDIMOBJECTCONTEXTDATA(), true) {
  }

}