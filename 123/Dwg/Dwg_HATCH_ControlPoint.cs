//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_HATCH_ControlPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_HATCH_ControlPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_HATCH_ControlPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_HATCH_ControlPoint() {
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
          LibreDWGPINVOKE.delete_Dwg_HATCH_ControlPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_HATCH_PathSeg parent {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_parent_set(swigCPtr, Dwg_HATCH_PathSeg.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_parent_get(swigCPtr);
      Dwg_HATCH_PathSeg ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_HATCH_PathSeg(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD point {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_point_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_point_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public double weight {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_weight_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_HATCH_ControlPoint_weight_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_HATCH_ControlPoint() : this(LibreDWGPINVOKE.new_Dwg_HATCH_ControlPoint(), true) {
  }

}