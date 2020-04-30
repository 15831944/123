//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_MLINE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_MLINE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_MLINE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_MLINE() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_MLINE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MLINE_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public double scale {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_scale_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MLINE_scale_get(swigCPtr);
      return ret;
    } 
  }

  public byte justification {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_justification_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MLINE_justification_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD base_point {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_base_point_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MLINE_base_point_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD extrusion {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_extrusion_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MLINE_extrusion_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public ushort flags {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_flags_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MLINE_flags_get(swigCPtr);
      return ret;
    } 
  }

  public byte num_lines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_num_lines_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MLINE_num_lines_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_verts {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_num_verts_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MLINE_num_verts_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_MLINE_vertex verts {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_verts_set(swigCPtr, Dwg_MLINE_vertex.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MLINE_verts_get(swigCPtr);
      Dwg_MLINE_vertex ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_MLINE_vertex(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref mlinestyle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MLINE_mlinestyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MLINE_mlinestyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Entity_MLINE() : this(LibreDWGPINVOKE.new_Dwg_Entity_MLINE(), true) {
  }

}