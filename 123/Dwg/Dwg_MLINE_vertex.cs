//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_MLINE_vertex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_MLINE_vertex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_MLINE_vertex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_MLINE_vertex() {
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
          LibreDWGPINVOKE.delete_Dwg_MLINE_vertex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Entity_MLINE parent {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_parent_set(swigCPtr, Dwg_Entity_MLINE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_vertex_parent_get(swigCPtr);
      Dwg_Entity_MLINE ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity_MLINE(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD vertex {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_vertex_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_vertex_vertex_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD vertex_direction {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_vertex_direction_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_vertex_vertex_direction_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD miter_direction {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_miter_direction_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_vertex_miter_direction_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public byte num_lines {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_num_lines_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_MLINE_vertex_num_lines_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_MLINE_line lines {
    set {
      LibreDWGPINVOKE.Dwg_MLINE_vertex_lines_set(swigCPtr, Dwg_MLINE_line.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_MLINE_vertex_lines_get(swigCPtr);
      Dwg_MLINE_line ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_MLINE_line(cPtr, false);
      return ret;
    } 
  }

  public Dwg_MLINE_vertex() : this(LibreDWGPINVOKE.new_Dwg_MLINE_vertex(), true) {
  }

}