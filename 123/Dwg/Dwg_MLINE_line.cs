//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_MLINE_line : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_MLINE_line(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_MLINE_line obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_MLINE_line() {
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
          LibreDWGPINVOKE.delete_Dwg_MLINE_line(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_MLINE_vertex parent {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_line_parent_set(swigCPtr, Dwg_MLINE_vertex.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_line_parent_get(swigCPtr);
      Dwg_MLINE_vertex ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_MLINE_vertex(cPtr, false);
      return ret;
    } 
  }

  public ushort num_segparms {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_line_num_segparms_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_MLINE_line_num_segparms_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double segparms {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_line_segparms_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_line_segparms_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public ushort num_areafillparms {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_line_num_areafillparms_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_MLINE_line_num_areafillparms_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double areafillparms {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_line_areafillparms_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_line_areafillparms_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public Dwg_MLINE_line() : this(LibreDWGPINVOKE.new_Dwg_MLINE_line(), true) {
  }

}
