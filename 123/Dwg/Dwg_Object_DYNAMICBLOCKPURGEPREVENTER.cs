//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_DYNAMICBLOCKPURGEPREVENTER : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_DYNAMICBLOCKPURGEPREVENTER(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_DYNAMICBLOCKPURGEPREVENTER obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_DYNAMICBLOCKPURGEPREVENTER() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_DYNAMICBLOCKPURGEPREVENTER(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort flag {
    set {
      LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_flag_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_flag_get(swigCPtr);
      return ret;
    } 
  }

  public ushort unknown_rs1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_unknown_rs1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_DYNAMICBLOCKPURGEPREVENTER_unknown_rs1_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_DYNAMICBLOCKPURGEPREVENTER() : this(LibreDWGPINVOKE.new_Dwg_Object_DYNAMICBLOCKPURGEPREVENTER(), true) {
  }

}
