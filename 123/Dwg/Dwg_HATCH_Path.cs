//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_HATCH_Path : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_HATCH_Path(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_HATCH_Path obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_HATCH_Path() {
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
          LibreDWGPINVOKE.delete_Dwg_HATCH_Path(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Entity_HATCH parent {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_parent_set(swigCPtr, Dwg_Entity_HATCH.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_HATCH_Path_parent_get(swigCPtr);
      Dwg_Entity_HATCH ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity_HATCH(cPtr, false);
      return ret;
    } 
  }

  public uint flag {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_flag_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_HATCH_Path_flag_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_segs_or_paths {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_num_segs_or_paths_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_HATCH_Path_num_segs_or_paths_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_HATCH_PathSeg segs {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_segs_set(swigCPtr, Dwg_HATCH_PathSeg.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_HATCH_Path_segs_get(swigCPtr);
      Dwg_HATCH_PathSeg ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_HATCH_PathSeg(cPtr, false);
      return ret;
    } 
  }

  public byte bulges_present {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_bulges_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_HATCH_Path_bulges_present_get(swigCPtr);
      return ret;
    } 
  }

  public byte closed {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_closed_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_HATCH_Path_closed_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_HATCH_PolylinePath polyline_paths {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_polyline_paths_set(swigCPtr, Dwg_HATCH_PolylinePath.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_HATCH_Path_polyline_paths_get(swigCPtr);
      Dwg_HATCH_PolylinePath ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_HATCH_PolylinePath(cPtr, false);
      return ret;
    } 
  }

  public uint num_boundary_handles {
    set {
      LibreDWGPINVOKE.Dwg_HATCH_Path_num_boundary_handles_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_HATCH_Path_num_boundary_handles_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_HATCH_Path() : this(LibreDWGPINVOKE.new_Dwg_HATCH_Path(), true) {
  }

}
