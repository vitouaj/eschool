<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Models\Courses;
use Illuminate\Http\Request;

class CourseController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        $courses = Courses::all();
        return response()->json([
            'status' => true,
            'courses' => $courses,
            'code' => 200
        ]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        //
    }

    /**
     * Display the specified resource.
     */
    public function show(Courses $courses)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Courses $courses)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Courses $courses)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Courses $courses)
    {
        //
    }
}
