/// <reference path="c:\docs\personal\IVC\src\IVC.WebPortal\public/js/libs/nginfinitescroll/build/ng-infinite-scroll.min.js" />
module.exports = function (grunt) {
    
    require('jit-grunt')(grunt);
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-bower-install');


    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        less: {
            dev: {
                options: {
                    compress: false,
                    yuicompress: false,
                    optimization: 2,
                    sourceMap: true,
                    sourceMapFilename: "public/css/master.css.map",
                    sourceMapURL: "/public/css/master.css.map"

                },
                files: {
					"public/css/master.css": "less/master.less" // destination file and source file
                }
            },

            prod: {
            	options: {
            		compress: true,
            		yuicompress: true,
            		optimization: 2,
            		sourceMap: true,
            		sourceMapFilename: "public/css/master.css.map",
            		sourceMapURL: "/public/css/master.css.map"
            	},
            	files: {
            		"public/css/master.min.css": "less/master.less" // destination file and source file
            	}
            },

        },

        watch: {
        	files: ['less/**/*.less'],
        	tasks: ["less"],
                options: {
                    nospawn: true
                }
        },
        

        bowerInstall: {

            target: {

                // Point to the files that should be updated when 
                // you run `grunt bower-install` 
                src: [
                  'Views/Shared/Scripts.cshtml'
                ],

                // Optional: 
                // --------- 
                cwd: '',
                dependencies: true,
                devDependencies: false,
                fileTypes: {},
                ignorePath: '../..',
                overrides: {},
                exclude: []
            }
        }


    });
    
    grunt.registerTask('default', ['less:dev', 'watch']);

    grunt.registerTask('bower', ['bowerInstall']);

};
